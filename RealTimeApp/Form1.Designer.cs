
namespace RealTimeApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iDriver1 = new ATSCADA.iDriver();
            this.iLabel1 = new ATSCADA.iWinTools.Data.iLabel();
            this.iWebService1 = new ATSCADA.WebService.iWebService(this.components);
            this.iLabel2 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel3 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel4 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel5 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel6 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel7 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel8 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel9 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel10 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel11 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel12 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel13 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel14 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel15 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel16 = new ATSCADA.iWinTools.Data.iLabel();
            this.SuspendLayout();
            // 
            // iDriver1
            // 
            this.iDriver1.Designmode = false;
            this.iDriver1.GetTaskTimeOut = ((ulong)(5000ul));
            this.iDriver1.MaxTagWriteTimes = 10;
            this.iDriver1.ProjectFile = null;
            this.iDriver1.WaitingTime = 3000;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Driver = this.iDriver1;
            this.iLabel1.Location = new System.Drawing.Point(48, 37);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(49, 13);
            this.iLabel1.TabIndex = 0;
            this.iLabel1.TagName = "AFChemTX01.QuyTrinh";
            this.iLabel1.Text = "Quy trình";
            // 
            // iWebService1
            // 
            this.iWebService1.Driver = this.iDriver1;
            this.iWebService1.Port = ((uint)(8010u));
            this.iWebService1.Server = "localhost";
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Driver = this.iDriver1;
            this.iLabel2.Location = new System.Drawing.Point(116, 37);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(82, 13);
            this.iLabel2.TabIndex = 1;
            this.iLabel2.TagName = "AFChemTX01.CongDoanMay";
            this.iLabel2.Text = "Công đoạn máy";
            // 
            // iLabel3
            // 
            this.iLabel3.AutoSize = true;
            this.iLabel3.Driver = this.iDriver1;
            this.iLabel3.Location = new System.Drawing.Point(289, 121);
            this.iLabel3.Name = "iLabel3";
            this.iLabel3.Size = new System.Drawing.Size(111, 13);
            this.iLabel3.TabIndex = 2;
            this.iLabel3.TagName = "AFChemTX01.NhietDoBonTronTren";
            this.iLabel3.Text = "Nhiệt độ bồn trộn trên";
            // 
            // iLabel4
            // 
            this.iLabel4.AutoSize = true;
            this.iLabel4.Driver = this.iDriver1;
            this.iLabel4.Location = new System.Drawing.Point(52, 121);
            this.iLabel4.Name = "iLabel4";
            this.iLabel4.Size = new System.Drawing.Size(100, 13);
            this.iLabel4.TabIndex = 3;
            this.iLabel4.TagName = "AFChemTX01.NhietDoMoiTruong";
            this.iLabel4.Text = "Nhiệt độ môi trường";
            // 
            // iLabel5
            // 
            this.iLabel5.AutoSize = true;
            this.iLabel5.Driver = this.iDriver1;
            this.iLabel5.Location = new System.Drawing.Point(432, 121);
            this.iLabel5.Name = "iLabel5";
            this.iLabel5.Size = new System.Drawing.Size(113, 13);
            this.iLabel5.TabIndex = 4;
            this.iLabel5.TagName = "AFChemTX01.NhietDoBonTronGiua";
            this.iLabel5.Text = "Nhiệt độ bồn trộn giữa";
            // 
            // iLabel6
            // 
            this.iLabel6.AutoSize = true;
            this.iLabel6.Driver = this.iDriver1;
            this.iLabel6.Location = new System.Drawing.Point(180, 121);
            this.iLabel6.Name = "iLabel6";
            this.iLabel6.Size = new System.Drawing.Size(90, 13);
            this.iLabel6.TabIndex = 5;
            this.iLabel6.TagName = "AFChemTX01.DoAmMoiTruong";
            this.iLabel6.Text = "Độ ẩm môi trường";
            // 
            // iLabel7
            // 
            this.iLabel7.AutoSize = true;
            this.iLabel7.Driver = this.iDriver1;
            this.iLabel7.Location = new System.Drawing.Point(531, 76);
            this.iLabel7.Name = "iLabel7";
            this.iLabel7.Size = new System.Drawing.Size(62, 13);
            this.iLabel7.TabIndex = 6;
            this.iLabel7.TagName = "AFChemTX01.ApSuat";
            this.iLabel7.Text = "Áp suất khí";
            // 
            // iLabel8
            // 
            this.iLabel8.AutoSize = true;
            this.iLabel8.Driver = this.iDriver1;
            this.iLabel8.Location = new System.Drawing.Point(218, 37);
            this.iLabel8.Name = "iLabel8";
            this.iLabel8.Size = new System.Drawing.Size(91, 13);
            this.iLabel8.TabIndex = 7;
            this.iLabel8.TagName = "AFChemTX01.ThoiGianCapLieu";
            this.iLabel8.Text = "Thời gian cấp liệu";
            // 
            // iLabel9
            // 
            this.iLabel9.AutoSize = true;
            this.iLabel9.Driver = this.iDriver1;
            this.iLabel9.Location = new System.Drawing.Point(329, 37);
            this.iLabel9.Name = "iLabel9";
            this.iLabel9.Size = new System.Drawing.Size(81, 13);
            this.iLabel9.TabIndex = 8;
            this.iLabel9.TagName = "AFChemTX01.ThoiGianTron1";
            this.iLabel9.Text = "Thời gian trộn 1";
            // 
            // iLabel10
            // 
            this.iLabel10.AutoSize = true;
            this.iLabel10.Driver = this.iDriver1;
            this.iLabel10.Location = new System.Drawing.Point(432, 37);
            this.iLabel10.Name = "iLabel10";
            this.iLabel10.Size = new System.Drawing.Size(86, 13);
            this.iLabel10.TabIndex = 9;
            this.iLabel10.TagName = "AFChemTX01.ThoiGianXaDay";
            this.iLabel10.Text = "Thời gian xả đáy";
            // 
            // iLabel11
            // 
            this.iLabel11.AutoSize = true;
            this.iLabel11.Driver = this.iDriver1;
            this.iLabel11.Location = new System.Drawing.Point(48, 76);
            this.iLabel11.Name = "iLabel11";
            this.iLabel11.Size = new System.Drawing.Size(104, 13);
            this.iLabel11.TabIndex = 10;
            this.iLabel11.TagName = "AFChemTX01.ThoiGianHutXaDay";
            this.iLabel11.Text = "Thời gian hút xả đáy";
            // 
            // iLabel12
            // 
            this.iLabel12.AutoSize = true;
            this.iLabel12.Driver = this.iDriver1;
            this.iLabel12.Location = new System.Drawing.Point(180, 76);
            this.iLabel12.Name = "iLabel12";
            this.iLabel12.Size = new System.Drawing.Size(81, 13);
            this.iLabel12.TabIndex = 11;
            this.iLabel12.TagName = "AFChemTX01.ThoiGianTron2";
            this.iLabel12.Text = "Thời gian trộn 2";
            // 
            // iLabel13
            // 
            this.iLabel13.AutoSize = true;
            this.iLabel13.Driver = this.iDriver1;
            this.iLabel13.Location = new System.Drawing.Point(553, 37);
            this.iLabel13.Name = "iLabel13";
            this.iLabel13.Size = new System.Drawing.Size(110, 13);
            this.iLabel13.TabIndex = 12;
            this.iLabel13.TagName = "AFChemTX01.ThoiGianRungXaDay";
            this.iLabel13.Text = "Thời gian rung xả đáy";
            // 
            // iLabel14
            // 
            this.iLabel14.AutoSize = true;
            this.iLabel14.Driver = this.iDriver1;
            this.iLabel14.Location = new System.Drawing.Point(387, 76);
            this.iLabel14.Name = "iLabel14";
            this.iLabel14.Size = new System.Drawing.Size(116, 13);
            this.iLabel14.TabIndex = 13;
            this.iLabel14.TagName = "AFChemTX01.ThoiGianRungXaHang";
            this.iLabel14.Text = "Thời gian rung xả hàng";
            // 
            // iLabel15
            // 
            this.iLabel15.AutoSize = true;
            this.iLabel15.Driver = this.iDriver1;
            this.iLabel15.Location = new System.Drawing.Point(278, 76);
            this.iLabel15.Name = "iLabel15";
            this.iLabel15.Size = new System.Drawing.Size(92, 13);
            this.iLabel15.TabIndex = 14;
            this.iLabel15.TagName = "AFChemTX01.ThoiGianXaHang";
            this.iLabel15.Text = "Thời gian xả hàng";
            // 
            // iLabel16
            // 
            this.iLabel16.AutoSize = true;
            this.iLabel16.Driver = this.iDriver1;
            this.iLabel16.Location = new System.Drawing.Point(575, 121);
            this.iLabel16.Name = "iLabel16";
            this.iLabel16.Size = new System.Drawing.Size(113, 13);
            this.iLabel16.TabIndex = 15;
            this.iLabel16.TagName = "AFChemTX01.NhietDoBonTronDuoi";
            this.iLabel16.Text = "Nhiệt độ bồn trộn dưới";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iLabel16);
            this.Controls.Add(this.iLabel15);
            this.Controls.Add(this.iLabel14);
            this.Controls.Add(this.iLabel13);
            this.Controls.Add(this.iLabel12);
            this.Controls.Add(this.iLabel11);
            this.Controls.Add(this.iLabel10);
            this.Controls.Add(this.iLabel9);
            this.Controls.Add(this.iLabel8);
            this.Controls.Add(this.iLabel7);
            this.Controls.Add(this.iLabel6);
            this.Controls.Add(this.iLabel5);
            this.Controls.Add(this.iLabel4);
            this.Controls.Add(this.iLabel3);
            this.Controls.Add(this.iLabel2);
            this.Controls.Add(this.iLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATSCADA.iDriver iDriver1;
        private ATSCADA.iWinTools.Data.iLabel iLabel1;
        private ATSCADA.WebService.iWebService iWebService1;
        private ATSCADA.iWinTools.Data.iLabel iLabel2;
        private ATSCADA.iWinTools.Data.iLabel iLabel3;
        private ATSCADA.iWinTools.Data.iLabel iLabel4;
        private ATSCADA.iWinTools.Data.iLabel iLabel5;
        private ATSCADA.iWinTools.Data.iLabel iLabel6;
        private ATSCADA.iWinTools.Data.iLabel iLabel7;
        private ATSCADA.iWinTools.Data.iLabel iLabel8;
        private ATSCADA.iWinTools.Data.iLabel iLabel9;
        private ATSCADA.iWinTools.Data.iLabel iLabel10;
        private ATSCADA.iWinTools.Data.iLabel iLabel11;
        private ATSCADA.iWinTools.Data.iLabel iLabel12;
        private ATSCADA.iWinTools.Data.iLabel iLabel13;
        private ATSCADA.iWinTools.Data.iLabel iLabel14;
        private ATSCADA.iWinTools.Data.iLabel iLabel15;
        private ATSCADA.iWinTools.Data.iLabel iLabel16;
    }
}

