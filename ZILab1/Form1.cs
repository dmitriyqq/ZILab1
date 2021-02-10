using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZILab1
{
    public partial class Form1 : Form
    {
        private EncodingInfo[] Encodings { get; set; }
        public Form1()
        {
            InitializeComponent();
            Encodings = Encoding.GetEncodings();

            var encodingsArray = Encodings.Select(e => e.DisplayName).ToArray();
            encodeComboBox.Items.AddRange(encodingsArray);
            decodeComboBox.Items.AddRange(encodingsArray);
        }

        private int? GetCodePage(ComboBox comboBox)
        {
            if (encodeComboBox.SelectedItem != null)
            {
                var encodingInfo = Encodings.FirstOrDefault(enc => enc.DisplayName == encodeComboBox.SelectedItem);
                return encodingInfo?.CodePage;
            }

            return null;
        }

        private int? GetEncodingCodePage() => GetCodePage(encodeComboBox);
        private int? GetDecodingCodePage() => GetCodePage(decodeComboBox);

        private byte[] ConvertStringToByteArray(string data) => Array.ConvertAll<string, byte>(data.Split('-'), s => Convert.ToByte(s, 16));

        private void encodeButton_Click(object sender, EventArgs e)
        {
            var codePage = GetEncodingCodePage();
            if (codePage.HasValue)
            {
                var encoding = Encoding.GetEncoding(codePage.Value);
                var encodedStringBytes = encoding.GetBytes(encodeTextBox.Text);
                bytesTextBox.Text = BitConverter.ToString(encodedStringBytes);
                var decodeCodePage = GetDecodingCodePage();
                if (GetDecodingCodePage().HasValue)
                {
                    decodeTextBox.Text = Encoding.GetEncoding(decodeCodePage.Value).GetString(encodedStringBytes);
                }
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            var codePage = GetEncodingCodePage();
            var decodedCodePage = GetDecodingCodePage();

            if (codePage.HasValue && decodedCodePage.HasValue)
            {
                var encodedBytes = Encoding.GetEncoding(decodedCodePage.Value).GetBytes(decodeTextBox.Text);
                var text = Encoding.GetEncoding(codePage.Value).GetString(encodedBytes);
                encodeTextBox.Text = text;
            }
        }

        private void UpdateBytesButton_Click(object sender, EventArgs e)
        {
            var bytesText = bytesTextBox.Text;
            var bytesArray = ConvertStringToByteArray(bytesText);

            var codePage = GetEncodingCodePage();
            var decodedCodePage = GetDecodingCodePage();

            if (codePage.HasValue && decodedCodePage.HasValue)
            {
                encodeTextBox.Text = Encoding.GetEncoding(codePage.Value).GetString(bytesArray);
                decodeTextBox.Text = Encoding.GetEncoding(decodedCodePage.Value).GetString(bytesArray);
            }
        }
    }
}
