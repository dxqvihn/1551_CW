using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CW
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public class Question
        {
            public string Text { get; set; } // Câu hỏi
            public List<string> Options { get; set; } // Các đáp án
            public int Answer { get; set; } // Đáp án đúng (0, 1, 2, 3 cho 4 lựa chọn)
            public QuestionType Type { get; set; } // Loại câu hỏi
        }

        public enum QuestionType
        {
            MultipleChoice,
            OpenEnded,
            
        }

        public void SetNameToLabel(string name)
        {
            lbPlName.Text = name; // label1 là tên Label trong Form2
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void grpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnOption1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOption2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOption3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOption4_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        
    }
}
