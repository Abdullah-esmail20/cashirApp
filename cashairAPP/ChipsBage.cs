using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace cashairAPP
{
    public partial class ChipsBage : Form
    {
        public ChipsBage()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            Form fr1 = new homeBage(); // تأكد أن الاسم يطابق اسم الفورم الجديد عندك

            // 2. نظهر الصفحة الجديدة
            fr1.Show();

        }

        void UpdateGrandTotal()
        {
            double totalSum = 0;

            // نمر على كل صف في الجدول ونجمع العمود الرابع (الإجمالي)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null) // العمود رقم 3 هو عمود الإجمالي (لأن العد يبدأ من 0)
                {
                    totalSum += Convert.ToDouble(row.Cells[3].Value);
                }
            }

            // نعرض المجموع في الليبل الموجود أسفل الجدول
            // (تأكد أن اسم الليبل عندك label1 أو غيره للكود الصحيح)
            //lbToplam.Text = totalSum.ToString() + " $";
            lbToplam.Text = totalSum.ToString("N2", CultureInfo.InvariantCulture) + " $";
        }

        void AddProductToGrid(string name, double price)
        {
            // 1. فحص هل المنتج موجود مسبقاً؟
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // الخانة 0 هي اسم المنتج
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == name)
                {
                    // المنتج موجود! نزيد العدد فقط
                    int currentQty = Convert.ToInt32(row.Cells[2].Value); // الخانة 2 هي العدد
                    row.Cells[2].Value = currentQty + 1; // زيادة العدد بـ 1

                    // تحديث إجمالي السطر (السعر × العدد الجديد)
                    row.Cells[3].Value = price * (currentQty + 1);

                    // تحديث المجموع الكلي والخروج
                    UpdateGrandTotal();
                    return;
                }
            }

            dataGridView1.Rows.Add(name, price, 1, price);

            // تحديث المجموع الكلي
            UpdateGrandTotal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddProductToGrid("Classic Salted Chips", 2.3);
            // 1. تحويل الـ sender إلى PictureBox لنتحكم فيه
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            AddProductToGrid("Cheese-Flavored Chips", 3.3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddProductToGrid("Spicy Chili Chips", 1.3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddProductToGrid("Barbecue-Flavored Chips", 6.3);
        }

       


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // نتأكد أن هناك سطراً محدداً حالياً
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // نحذف السطر المحدد
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
                    }

                    // أهم خطوة: إعادة حساب المجموع بعد الحذف!
                    UpdateGrandTotal();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Home=new homeBage();
            Home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            // 2. تصفير المجموع الكلي
            label1.Text = "0.00 $";
        }
    }
}
