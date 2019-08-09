using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using soymichelApp.adminApp.src.controllers;
using soymichelApp.adminApp.src.models;

namespace soymichelApp.adminApp
{
    public partial class HomeForm : Form
    {

        PostController postController = new PostController();

        PostModel selectedPost;

        bool isLoaded = false;

        public HomeForm()
        {
            InitializeComponent();
        }

        void clearControls()
        {

            if(selectedPost != null) { selectedPost = null; }

            titleTextBox.Clear();
            typePostComboBox.SelectedIndex = -1;
            avatarURLTextBox.Clear();
            photoURLTextBox.Clear();
            categoriesComboBox.SelectedIndex = -1;
            otherValueTextBox.Clear();

            saveButton.Enabled = true;
            deleteButton.Enabled = false;

            titleTextBox.Focus();

        }

        private void isWaiting(bool loading = true)
        {
            newButton.Enabled = !loading;
            saveButton.Enabled = !loading;
            deleteButton.Enabled = !loading;
            postsDataGridView.Enabled = !loading;
            waitingMessageLabel.Text = loading ? "Cargando..." : "Listo";
        }

        private void setDataToPostTypes()
        {
            typePostComboBox.DataSource = PostModel.postTypes;
            typePostComboBox.ValueMember = "Id";
            typePostComboBox.DisplayMember = "Caption";
            typePostComboBox.SelectedIndex = -1;
        }

        enum categoryType
        {
            academicCategories,
            projectCategories,
        }

        private void setDataToAcademicCategories(categoryType type)
        {
            switch (type)
            {
                case categoryType.academicCategories: {
                    categoriesComboBox.DataSource = PostModel.academicCategories;
                    otherValueLabel.Text = "Escuela:";
                    break;
                }
                case categoryType.projectCategories: {
                    categoriesComboBox.DataSource = PostModel.projectCategories;
                    otherValueLabel.Text = "Empresa:";
                    break;
                }
            }
            categoriesComboBox.ValueMember = "Id";
            categoriesComboBox.DisplayMember = "Caption";
            categoriesComboBox.SelectedIndex = -1;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            setDataToPostTypes();

            isLoaded = true;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {

            isWaiting();

            object data;

            if (typePostComboBox.SelectedValue.ToString() == "studies")
            {
                data = new
                {
                    category = categoriesComboBox.SelectedValue.ToString(),
                    school = otherValueTextBox.Text.Trim(),
                };
            }
            else
            {
                data = new
                {
                    category = categoriesComboBox.SelectedValue.ToString(),
                    projectCompany = otherValueTextBox.Text.Trim(),
                };
            }

            if (selectedPost == null)
            {

                await postController.AddAsync(new PostModel()
                {
                    AvatarURL = avatarURLTextBox.Text.Trim(),
                    CreatedDate = Timestamp.GetCurrentTimestamp(),
                    FavsCount = 0,
                    ModifiedDate = Timestamp.GetCurrentTimestamp(),
                    PhotoURL = photoURLTextBox.Text.Trim(),
                    PostType = typePostComboBox.SelectedValue.ToString(),
                    SharesCount = 0,
                    Title = titleTextBox.Text.Trim(),
                    Data = data,
                });

            }
            else
            {

                selectedPost.AvatarURL = avatarURLTextBox.Text.Trim();
                selectedPost.CreatedDate = Timestamp.GetCurrentTimestamp();
                selectedPost.FavsCount = 0;
                selectedPost.ModifiedDate = Timestamp.GetCurrentTimestamp();
                selectedPost.PhotoURL = photoURLTextBox.Text.Trim();
                selectedPost.PostType = typePostComboBox.SelectedValue.ToString();
                selectedPost.SharesCount = 0;
                selectedPost.Title = titleTextBox.Text.Trim();
                selectedPost.Data = data;

                await postController.UpdateAsync(selectedPost);

            }

            isWaiting(false);

            clearControls();

        }

        private void typePostComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                if (typePostComboBox.SelectedValue != null)
                {
                    setDataToAcademicCategories(
                        typePostComboBox.SelectedValue.ToString() == "studies"
                        ? categoryType.academicCategories
                        : categoryType.projectCategories
                    );
                }
                else
                {
                    categoriesComboBox.SelectedIndex = -1;
                    categoriesComboBox.DataSource = null;
                }
            }
        }

        private async void setDataToPostList()
        {

            try
            {

                postsDataGridView.DataSource = (from post in (await postController.GetPosts()) select new {
                    post.PostId,
                    post.PostType,
                    post.Title,
                    post.FavsCount,
                    post.SharesCount,
                    CreatedDate = post.CreatedDate.ToDateTime(),
                    ModifiedDate = post.ModifiedDate.ToDateTime(),
                    post.AvatarURL,
                    post.PhotoURL,
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void searchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setDataToPostList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            setDataToPostList();
        }

        private void setDataInControls(PostModel post)
        {
            try
            {
                titleTextBox.Text = post.Title;
                typePostComboBox.SelectedValue = post.PostType;
                avatarURLTextBox.Text = post.AvatarURL;
                photoURLTextBox.Text = post.PhotoURL;
                Dictionary<string, object> data = ((Dictionary<string, object>)post.Data);
                categoriesComboBox.SelectedValue = data["category"];
                if (post.PostType == "studies")
                {
                    otherValueTextBox.Text = data["school"].ToString();
                }
                else if (post.PostType == "projects")
                {
                    otherValueTextBox.Text = data["projectCompany"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void postsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (postsDataGridView.SelectedRows.Count > 0)
            {

                string postId = postsDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                selectedPost = await postController.GetPostById(postId);

                if (selectedPost != null)
                {

                    setDataInControls(selectedPost);

                    deleteButton.Enabled = true;

                }
                else
                {

                    setDataToPostList();

                    MessageBox.Show("No se encuentra este post.");

                }

            }

        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {

            isWaiting();

            await postController.RemoveAsync(selectedPost.PostId);

            clearControls();

            isWaiting(false);

        }

    }

}
