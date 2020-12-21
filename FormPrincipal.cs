using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;



namespace Interface
{
    public partial class frmXylem : Form
    {
        //Initialisation Timer
        int TimeS;
        bool isActive;

        public frmXylem()
        {
            InitializeComponent();
            lblDateDuJour.Text = DateTime.Now.ToString("yyyy-MM-dd");
            ChartLoad();
        }

        void ChartLoad()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                cmbPorts.SelectedIndex = 0;
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TimeS = 0;
            isActive = false;
        }

        //Control Arduino
        private void btnConnexionArduino_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("on");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeconnexionArduino_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("off");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbPorts.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Control Arduino Fin

        // Tab Login
        private void btnConnexion_Click(object sender, EventArgs e)
        {


            txtID_Pc.Text = txtLoginIdPc.Text;
            txtID_drf.Text = txtUtilisateur.Text;
            txtID_Arduino.Text = txtLoginArduino.Text;

            txtDateExperience.Text = lblDateDuJour.Text;
        }

        private void txtUtilisateur_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUtilisateur.Text))
            {
                e.Cancel = false;
                txtUtilisateur.Focus();
                errorProvider.SetError(txtUtilisateur, "Entrez votre identifiant drf.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUtilisateur, null);
            }
        }
        private void txtLoginArduino_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUtilisateur.Text))
            {
                e.Cancel = true;
                txtLoginArduino.Focus();
                errorProvider.SetError(txtLoginArduino, "Entrez l'Id du Arduino");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLoginArduino, null);
            }
        }

        private void txtLoginIdPc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginIdPc.Text))
            {
                e.Cancel = true;
                txtLoginIdPc.Focus();
                errorProvider.SetError(txtLoginIdPc, "Entrez l'Id du Pc.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLoginIdPc, null);
            }
        }



        //Tab Données Calibration

        //Tab Données Calibration Fin

        //Tab Données Experimentation

        //Tab Données Expériementation Fin

        //Tab PressureSensorCalibration

        //Tab PressureSensorCalibration Fin

        //Tab SingleKmeasurement

        //Tab SingleKmeasurement Fin

        //GroupBox Exchantillon
        private void btnModifierEchantillon_Click(object sender, EventArgs e)
        {
            txtEssence.ReadOnly = false;
            txtAgeArbre.ReadOnly = false;
            txtAgeEchantillon.ReadOnly = false;
            txtSolutionPerfusion.ReadOnly = false;
            txtPotentiels.ReadOnly = false;
            txtDiametreSegment1.ReadOnly = false;
            txtDiametreSegment2.ReadOnly = false;
            txtLongueurSegment.ReadOnly = false;
        }

        private void btnValiderEchantillon_Click(object sender, EventArgs e)
        {
            txtEssence.ReadOnly = true;
            txtAgeArbre.ReadOnly = true;
            txtAgeEchantillon.ReadOnly = true;
            txtSolutionPerfusion.ReadOnly = true;
            txtPotentiels.ReadOnly = true;
            txtDiametreSegment1.ReadOnly = true;
            txtDiametreSegment2.ReadOnly = true;
            txtLongueurSegment.ReadOnly = true;
        }
        //GroupBox Exhantillon Fin

        //GroupBox PeekTube

        private void btnModifierPeekTube_Click(object sender, EventArgs e)
        {
            txtMpa_mmol_Orange.ReadOnly = false;
            txtMpa_mmol_Bleu.ReadOnly = false;
            txtMpa_mmol_Jaune.ReadOnly = false;
            txtDiamPeekTubeOrange.ReadOnly = false;
            txtDiamPeekTubeBleu.ReadOnly = false;
            txtDiamPeekTubeJaune.ReadOnly = false;
            txtLongPeekTubeOrange.ReadOnly = false;
            txtLongPeekTubeBleu.ReadOnly = false;
            txtLongPeekTubeJaune.ReadOnly = false;
        }

        private void btnValiderPeekTube_Click(object sender, EventArgs e)
        {
            txtMpa_mmol_Orange.ReadOnly = true;
            txtMpa_mmol_Bleu.ReadOnly = true;
            txtMpa_mmol_Jaune.ReadOnly = true;
            txtDiamPeekTubeOrange.ReadOnly = true;
            txtDiamPeekTubeBleu.ReadOnly = true;
            txtDiamPeekTubeJaune.ReadOnly = true;
            txtLongPeekTubeOrange.ReadOnly = true;
            txtLongPeekTubeBleu.ReadOnly = true;
            txtLongPeekTubeJaune.ReadOnly = true;
        }

        private void rdbCouleurOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCouleurOrange.Checked)
            {
                rdbCouleurBleu.Checked = false;
                rdbCouleurJaune.Checked = false;
            }
        }

        private void rdbCouleurBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCouleurBleu.Checked)
            {
                rdbCouleurOrange.Checked = false;
                rdbCouleurJaune.Checked = false;
            }
        }

        private void rdbCouleurJaune_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCouleurJaune.Checked)
            {
                rdbCouleurOrange.Checked = false;
                rdbCouleurBleu.Checked = false;
            }
        }
        //GroupBox PeekTube Fin

        //GroupBox Expérience

        private void btnModifierExperience_Click(object sender, EventArgs e)
        {
            txtExperience.ReadOnly = true;
            txtXylem.ReadOnly = true;
            txtDateExperience.ReadOnly = true;
            rtxbDescription.ReadOnly = true;
        }

        private void btnValiderExperience_Click(object sender, EventArgs e)
        {
            txtExperience.ReadOnly = false;
            txtXylem.ReadOnly = false;
            txtDateExperience.ReadOnly = false;
            rtxbDescription.ReadOnly = false;
        }
        //GroupBox Expérience Fin

        //GroupBox Matériel

        private void btnModifierMateriel_Click(object sender, EventArgs e)
        {
            txtID_Pc.ReadOnly = true;
            txtNomPc.ReadOnly = true;
            txtID_drf.ReadOnly = true;
            txtID_Arduino.ReadOnly = true;
        }

        private void btnValiderMateriel_Click(object sender, EventArgs e)
        {
            txtID_Pc.ReadOnly = false;
            txtNomPc.ReadOnly = false;
            txtID_drf.ReadOnly = false;
            txtID_Arduino.ReadOnly = false;
        }
        //GroupBox Matériel Fin

        //Gestion Timer
        private void btnStartMesure_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTime();
        }

        private void ResetTime()
        {
            isActive = false;
            TimeS = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                TimeS++;
            }
            DrawTime();
        }

        private void DrawTime()
        {
            lblSeconde.Text = String.Format("{0:00}", TimeS);
        }
        //Gestion Timer Fin
    }
}
