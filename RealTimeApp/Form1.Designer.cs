
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
            this.iLabel17 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel18 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel19 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel20 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel21 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel22 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel23 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel24 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel25 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel26 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel27 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel28 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel29 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel30 = new ATSCADA.iWinTools.Data.iLabel();
            this.iLabel31 = new ATSCADA.iWinTools.Data.iLabel();
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
            // iLabel17
            // 
            this.iLabel17.AutoSize = true;
            this.iLabel17.Driver = this.iDriver1;
            this.iLabel17.Location = new System.Drawing.Point(52, 162);
            this.iLabel17.Name = "iLabel17";
            this.iLabel17.Size = new System.Drawing.Size(131, 13);
            this.iLabel17.TabIndex = 16;
            this.iLabel17.TagName = "AFChemTX01.Run";
            this.iLabel17.Text = "Trạng thái máy đang chạy";
            // 
            // iLabel18
            // 
            this.iLabel18.AutoSize = true;
            this.iLabel18.Driver = this.iDriver1;
            this.iLabel18.Location = new System.Drawing.Point(199, 162);
            this.iLabel18.Name = "iLabel18";
            this.iLabel18.Size = new System.Drawing.Size(120, 13);
            this.iLabel18.TabIndex = 17;
            this.iLabel18.TagName = "AFChemTX01.Stop";
            this.iLabel18.Text = "Trạng thái máy đang tắt";
            // 
            // iLabel19
            // 
            this.iLabel19.AutoSize = true;
            this.iLabel19.Driver = this.iDriver1;
            this.iLabel19.Location = new System.Drawing.Point(329, 162);
            this.iLabel19.Name = "iLabel19";
            this.iLabel19.Size = new System.Drawing.Size(127, 13);
            this.iLabel19.TabIndex = 18;
            this.iLabel19.TagName = "AFChemTX01.ThoiGianCaiDatCapLieu";
            this.iLabel19.Text = "Thời gian cài đặt cấp liệu";
            // 
            // iLabel20
            // 
            this.iLabel20.AutoSize = true;
            this.iLabel20.Driver = this.iDriver1;
            this.iLabel20.Location = new System.Drawing.Point(466, 162);
            this.iLabel20.Name = "iLabel20";
            this.iLabel20.Size = new System.Drawing.Size(153, 13);
            this.iLabel20.TabIndex = 19;
            this.iLabel20.TagName = "AFChemTX01.ThoiGianCaiDatCapLieuThem";
            this.iLabel20.Text = "Thời gian cài đặt cấp liệu thêm";
            // 
            // iLabel21
            // 
            this.iLabel21.AutoSize = true;
            this.iLabel21.Driver = this.iDriver1;
            this.iLabel21.Location = new System.Drawing.Point(52, 203);
            this.iLabel21.Name = "iLabel21";
            this.iLabel21.Size = new System.Drawing.Size(171, 13);
            this.iLabel21.TabIndex = 20;
            this.iLabel21.TagName = "AFChemTX01.ThoiGianCaiDatHutCapLieuThem";
            this.iLabel21.Text = "Thời gian cài đặt hút cấp liệu thêm";
            // 
            // iLabel22
            // 
            this.iLabel22.AutoSize = true;
            this.iLabel22.Driver = this.iDriver1;
            this.iLabel22.Location = new System.Drawing.Point(239, 203);
            this.iLabel22.Name = "iLabel22";
            this.iLabel22.Size = new System.Drawing.Size(117, 13);
            this.iLabel22.TabIndex = 21;
            this.iLabel22.TagName = "AFChemTX01.ThoiGianCaiDatTron1";
            this.iLabel22.Text = "Thời gian cài đặt trộn 1";
            // 
            // iLabel23
            // 
            this.iLabel23.AutoSize = true;
            this.iLabel23.Driver = this.iDriver1;
            this.iLabel23.Location = new System.Drawing.Point(362, 203);
            this.iLabel23.Name = "iLabel23";
            this.iLabel23.Size = new System.Drawing.Size(122, 13);
            this.iLabel23.TabIndex = 22;
            this.iLabel23.TagName = "AFChemTX01.ThoiGianCaiDatXaDay";
            this.iLabel23.Text = "Thời gian cài đặt xả đáy";
            // 
            // iLabel24
            // 
            this.iLabel24.AutoSize = true;
            this.iLabel24.Driver = this.iDriver1;
            this.iLabel24.Location = new System.Drawing.Point(497, 203);
            this.iLabel24.Name = "iLabel24";
            this.iLabel24.Size = new System.Drawing.Size(148, 13);
            this.iLabel24.TabIndex = 23;
            this.iLabel24.TagName = "AFChemTX01.ThoiGianCaiDatXaDayThem";
            this.iLabel24.Text = "Thời gian cài đặt xả đáy thêm";
            // 
            // iLabel25
            // 
            this.iLabel25.AutoSize = true;
            this.iLabel25.Driver = this.iDriver1;
            this.iLabel25.Location = new System.Drawing.Point(52, 236);
            this.iLabel25.Name = "iLabel25";
            this.iLabel25.Size = new System.Drawing.Size(140, 13);
            this.iLabel25.TabIndex = 24;
            this.iLabel25.TagName = "AFChemTX01.ThoiGianCaiDatHutXaDayThem";
            this.iLabel25.Text = "Thời gian cài đặt hút xả đáy";
            // 
            // iLabel26
            // 
            this.iLabel26.AutoSize = true;
            this.iLabel26.Driver = this.iDriver1;
            this.iLabel26.Location = new System.Drawing.Point(199, 236);
            this.iLabel26.Name = "iLabel26";
            this.iLabel26.Size = new System.Drawing.Size(146, 13);
            this.iLabel26.TabIndex = 25;
            this.iLabel26.TagName = "AFChemTX01.ThoiGianRungXaDay";
            this.iLabel26.Text = "Thời gian cài đặt rung xả đáy";
            // 
            // iLabel27
            // 
            this.iLabel27.AutoSize = true;
            this.iLabel27.Driver = this.iDriver1;
            this.iLabel27.Location = new System.Drawing.Point(351, 236);
            this.iLabel27.Name = "iLabel27";
            this.iLabel27.Size = new System.Drawing.Size(117, 13);
            this.iLabel27.TabIndex = 26;
            this.iLabel27.TagName = "AFChemTX01.ThoiGianCaiDatTron2";
            this.iLabel27.Text = "Thời gian cài đặt trộn 2";
            // 
            // iLabel28
            // 
            this.iLabel28.AutoSize = true;
            this.iLabel28.Driver = this.iDriver1;
            this.iLabel28.Location = new System.Drawing.Point(487, 236);
            this.iLabel28.Name = "iLabel28";
            this.iLabel28.Size = new System.Drawing.Size(152, 13);
            this.iLabel28.TabIndex = 27;
            this.iLabel28.TagName = "AFChemTX01.ThoiGianCaiDatRungXaHang";
            this.iLabel28.Text = "Thời gian cài đặt rung xả hàng";
            // 
            // iLabel29
            // 
            this.iLabel29.AutoSize = true;
            this.iLabel29.Driver = this.iDriver1;
            this.iLabel29.Location = new System.Drawing.Point(52, 267);
            this.iLabel29.Name = "iLabel29";
            this.iLabel29.Size = new System.Drawing.Size(128, 13);
            this.iLabel29.TabIndex = 28;
            this.iLabel29.TagName = "AFChemTX01.ThoiGianCaiDatXaHang";
            this.iLabel29.Text = "Thời gian cài đặt xả hàng";
            // 
            // iLabel30
            // 
            this.iLabel30.AutoSize = true;
            this.iLabel30.Driver = this.iDriver1;
            this.iLabel30.Location = new System.Drawing.Point(199, 267);
            this.iLabel30.Name = "iLabel30";
            this.iLabel30.Size = new System.Drawing.Size(139, 13);
            this.iLabel30.TabIndex = 29;
            this.iLabel30.TagName = "AFChemTX01.DatNguongNhietDoMoiTruong";
            this.iLabel30.Text = "Ngưỡng nhiệt độ môi trường";
            // 
            // iLabel31
            // 
            this.iLabel31.AutoSize = true;
            this.iLabel31.Driver = this.iDriver1;
            this.iLabel31.Location = new System.Drawing.Point(351, 267);
            this.iLabel31.Name = "iLabel31";
            this.iLabel31.Size = new System.Drawing.Size(130, 13);
            this.iLabel31.TabIndex = 30;
            this.iLabel31.TagName = "AFChemTX01.DatNguongDoAmMoiTruong";
            this.iLabel31.Text = "Ngưỡng độ ẩm môi trường";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iLabel31);
            this.Controls.Add(this.iLabel30);
            this.Controls.Add(this.iLabel29);
            this.Controls.Add(this.iLabel28);
            this.Controls.Add(this.iLabel27);
            this.Controls.Add(this.iLabel26);
            this.Controls.Add(this.iLabel25);
            this.Controls.Add(this.iLabel24);
            this.Controls.Add(this.iLabel23);
            this.Controls.Add(this.iLabel22);
            this.Controls.Add(this.iLabel21);
            this.Controls.Add(this.iLabel20);
            this.Controls.Add(this.iLabel19);
            this.Controls.Add(this.iLabel18);
            this.Controls.Add(this.iLabel17);
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
        private ATSCADA.iWinTools.Data.iLabel iLabel17;
        private ATSCADA.iWinTools.Data.iLabel iLabel18;
        private ATSCADA.iWinTools.Data.iLabel iLabel19;
        private ATSCADA.iWinTools.Data.iLabel iLabel20;
        private ATSCADA.iWinTools.Data.iLabel iLabel21;
        private ATSCADA.iWinTools.Data.iLabel iLabel22;
        private ATSCADA.iWinTools.Data.iLabel iLabel23;
        private ATSCADA.iWinTools.Data.iLabel iLabel24;
        private ATSCADA.iWinTools.Data.iLabel iLabel25;
        private ATSCADA.iWinTools.Data.iLabel iLabel26;
        private ATSCADA.iWinTools.Data.iLabel iLabel27;
        private ATSCADA.iWinTools.Data.iLabel iLabel28;
        private ATSCADA.iWinTools.Data.iLabel iLabel29;
        private ATSCADA.iWinTools.Data.iLabel iLabel30;
        private ATSCADA.iWinTools.Data.iLabel iLabel31;
    }
}

