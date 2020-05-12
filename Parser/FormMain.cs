using Parser.Core;
using Parser.Core.Metanit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;
        public FormMain()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(new MetanitParser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {

            ListParagraphs.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new MetanitSettings(TextBoxCategory.Text, 
                                                  TextBoxGuide.Text, 
                                                  (int)NumericStartPart.Value,
                                                  (int)NumericEndPart.Value,
                                                  (int)NumericStartArticle.Value,
                                                  (int)NumericEndArticle.Value);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {

        }
    }
}
