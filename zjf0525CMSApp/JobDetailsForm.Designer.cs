using System.Windows.Forms;

namespace zjf0525CMSApp
{
    partial class JobDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOilChanged = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.txtKMs = new System.Windows.Forms.TextBox();
            this.txtTires = new System.Windows.Forms.TextBox();
            this.txtBalancing = new System.Windows.Forms.TextBox();
            this.txtAlignment = new System.Windows.Forms.TextBox();
            this.txtTuning = new System.Windows.Forms.TextBox();
            this.txtOilQty = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtWeights = new System.Windows.Forms.TextBox();
            this.txtAirFilter = new System.Windows.Forms.TextBox();
            this.txtFuelFilter = new System.Windows.Forms.TextBox();
            this.txtPlugQty = new System.Windows.Forms.TextBox();
            this.txtPlug = new System.Windows.Forms.TextBox();
            this.txtCondenser = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtGearOilQty = new System.Windows.Forms.TextBox();
            this.txtGearOil = new System.Windows.Forms.TextBox();
            this.txtOilFilter = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "JobDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "WorkerId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "KMs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tuning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alignment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balancing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tires";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Weights";
            // 
            // txtOilChanged
            // 
            this.txtOilChanged.AutoSize = true;
            this.txtOilChanged.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilChanged.Location = new System.Drawing.Point(53, 280);
            this.txtOilChanged.Name = "txtOilChanged";
            this.txtOilChanged.Size = new System.Drawing.Size(94, 20);
            this.txtOilChanged.TabIndex = 9;
            this.txtOilChanged.Text = "OilChanged";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "OilQty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(422, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Remarks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(422, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "AirFilter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(422, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "FuelFilter";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(422, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "PlugQty";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(422, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 17;
            this.label17.Text = "Plug";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(422, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Condenser";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(422, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "Point";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(422, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "GearOilQty";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(422, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 20);
            this.label21.TabIndex = 13;
            this.label21.Text = "GearOil";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(422, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "OilFilter";
            // 
            // txtCarNo
            // 
            this.txtCarNo.Location = new System.Drawing.Point(156, 44);
            this.txtCarNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(160, 25);
            this.txtCarNo.TabIndex = 22;
            this.txtCarNo.Leave += new System.EventHandler(this.txtCarNo_Leave);
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Location = new System.Drawing.Point(156, 97);
            this.txtWorkerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(160, 25);
            this.txtWorkerId.TabIndex = 24;
            // 
            // txtKMs
            // 
            this.txtKMs.Location = new System.Drawing.Point(156, 122);
            this.txtKMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKMs.Name = "txtKMs";
            this.txtKMs.Size = new System.Drawing.Size(160, 25);
            this.txtKMs.TabIndex = 25;
            // 
            // txtTires
            // 
            this.txtTires.Location = new System.Drawing.Point(156, 225);
            this.txtTires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTires.Name = "txtTires";
            this.txtTires.Size = new System.Drawing.Size(160, 25);
            this.txtTires.TabIndex = 29;
            // 
            // txtBalancing
            // 
            this.txtBalancing.Location = new System.Drawing.Point(156, 201);
            this.txtBalancing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalancing.Name = "txtBalancing";
            this.txtBalancing.Size = new System.Drawing.Size(160, 25);
            this.txtBalancing.TabIndex = 28;
            // 
            // txtAlignment
            // 
            this.txtAlignment.Location = new System.Drawing.Point(156, 174);
            this.txtAlignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlignment.Name = "txtAlignment";
            this.txtAlignment.Size = new System.Drawing.Size(160, 25);
            this.txtAlignment.TabIndex = 27;
            // 
            // txtTuning
            // 
            this.txtTuning.Location = new System.Drawing.Point(156, 147);
            this.txtTuning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuning.Name = "txtTuning";
            this.txtTuning.Size = new System.Drawing.Size(160, 25);
            this.txtTuning.TabIndex = 26;
            // 
            // txtOilQty
            // 
            this.txtOilQty.Location = new System.Drawing.Point(156, 304);
            this.txtOilQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOilQty.Name = "txtOilQty";
            this.txtOilQty.Size = new System.Drawing.Size(160, 25);
            this.txtOilQty.TabIndex = 32;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(156, 277);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(160, 25);
            this.textBox11.TabIndex = 31;
            // 
            // txtWeights
            // 
            this.txtWeights.Location = new System.Drawing.Point(156, 251);
            this.txtWeights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeights.Name = "txtWeights";
            this.txtWeights.Size = new System.Drawing.Size(160, 25);
            this.txtWeights.TabIndex = 30;
            // 
            // txtAirFilter
            // 
            this.txtAirFilter.Location = new System.Drawing.Point(533, 254);
            this.txtAirFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAirFilter.Name = "txtAirFilter";
            this.txtAirFilter.Size = new System.Drawing.Size(160, 25);
            this.txtAirFilter.TabIndex = 42;
            // 
            // txtFuelFilter
            // 
            this.txtFuelFilter.Location = new System.Drawing.Point(533, 228);
            this.txtFuelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFuelFilter.Name = "txtFuelFilter";
            this.txtFuelFilter.Size = new System.Drawing.Size(160, 25);
            this.txtFuelFilter.TabIndex = 41;
            // 
            // txtPlugQty
            // 
            this.txtPlugQty.Location = new System.Drawing.Point(533, 204);
            this.txtPlugQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlugQty.Name = "txtPlugQty";
            this.txtPlugQty.Size = new System.Drawing.Size(160, 25);
            this.txtPlugQty.TabIndex = 40;
            // 
            // txtPlug
            // 
            this.txtPlug.Location = new System.Drawing.Point(533, 177);
            this.txtPlug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlug.Name = "txtPlug";
            this.txtPlug.Size = new System.Drawing.Size(160, 25);
            this.txtPlug.TabIndex = 39;
            // 
            // txtCondenser
            // 
            this.txtCondenser.Location = new System.Drawing.Point(533, 150);
            this.txtCondenser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCondenser.Name = "txtCondenser";
            this.txtCondenser.Size = new System.Drawing.Size(160, 25);
            this.txtCondenser.TabIndex = 38;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(533, 125);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(160, 25);
            this.txtPoint.TabIndex = 37;
            // 
            // txtGearOilQty
            // 
            this.txtGearOilQty.Location = new System.Drawing.Point(533, 100);
            this.txtGearOilQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGearOilQty.Name = "txtGearOilQty";
            this.txtGearOilQty.Size = new System.Drawing.Size(160, 25);
            this.txtGearOilQty.TabIndex = 36;
            // 
            // txtGearOil
            // 
            this.txtGearOil.Location = new System.Drawing.Point(533, 73);
            this.txtGearOil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGearOil.Name = "txtGearOil";
            this.txtGearOil.Size = new System.Drawing.Size(160, 25);
            this.txtGearOil.TabIndex = 35;
            // 
            // txtOilFilter
            // 
            this.txtOilFilter.Location = new System.Drawing.Point(533, 47);
            this.txtOilFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOilFilter.Name = "txtOilFilter";
            this.txtOilFilter.Size = new System.Drawing.Size(160, 25);
            this.txtOilFilter.TabIndex = 34;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(533, 282);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(160, 25);
            this.txtRemarks.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(190, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(291, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 29);
            this.button2.TabIndex = 45;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(493, 370);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 29);
            this.button3.TabIndex = 46;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(551, 370);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 29);
            this.button4.TabIndex = 47;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(352, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 27);
            this.textBox1.TabIndex = 48;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoad.Location = new System.Drawing.Point(56, 409);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 31);
            this.btnLoad.TabIndex = 49;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(156, 409);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 31);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(256, 409);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 31);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(352, 409);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 31);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelAll.Location = new System.Drawing.Point(443, 409);
            this.btnCancelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(84, 31);
            this.btnCancelAll.TabIndex = 53;
            this.btnCancelAll.Text = "Cancel All";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(533, 409);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 31);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(622, 409);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 72);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 27);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtAirFilter);
            this.Controls.Add(this.txtFuelFilter);
            this.Controls.Add(this.txtPlugQty);
            this.Controls.Add(this.txtPlug);
            this.Controls.Add(this.txtCondenser);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtGearOilQty);
            this.Controls.Add(this.txtGearOil);
            this.Controls.Add(this.txtOilFilter);
            this.Controls.Add(this.txtOilQty);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.txtWeights);
            this.Controls.Add(this.txtTires);
            this.Controls.Add(this.txtBalancing);
            this.Controls.Add(this.txtAlignment);
            this.Controls.Add(this.txtTuning);
            this.Controls.Add(this.txtKMs);
            this.Controls.Add(this.txtWorkerId);
            this.Controls.Add(this.txtCarNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOilChanged);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label txtOilChanged;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtCarNo;
        private TextBox txtWorkerId;
        private TextBox txtKMs;
        private TextBox txtTires;
        private TextBox txtBalancing;
        private TextBox txtAlignment;
        private TextBox txtTuning;
        private TextBox txtOilQty;
        private TextBox textBox11;
        private TextBox txtWeights;
        private TextBox txtAirFilter;
        private TextBox txtFuelFilter;
        private TextBox txtPlugQty;
        private TextBox txtPlug;
        private TextBox txtCondenser;
        private TextBox txtPoint;
        private TextBox txtGearOilQty;
        private TextBox txtGearOil;
        private TextBox txtOilFilter;
        private TextBox txtRemarks;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnCancelAll;
        private Button btnUpdate;
        private Button btnExit;
        private DateTimePicker dateTimePicker1;
    }
}