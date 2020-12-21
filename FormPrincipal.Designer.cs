
namespace Interface
{
    partial class frmXylem
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
            System.Windows.Forms.GroupBox grbPeekTube;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnEstValidePeekTube = new System.Windows.Forms.Button();
            this.btnModifierPeekTube = new System.Windows.Forms.Button();
            this.btnValiderPeekTube = new System.Windows.Forms.Button();
            this.txtResistancePeekTube = new System.Windows.Forms.TextBox();
            this.lblResistancePeekTube = new System.Windows.Forms.Label();
            this.lblLongPeekTube = new System.Windows.Forms.Label();
            this.txtDiamPeekTubeBleu = new System.Windows.Forms.TextBox();
            this.txtDiamPeekTubeJaune = new System.Windows.Forms.TextBox();
            this.txtLongPeekTubeBleu = new System.Windows.Forms.TextBox();
            this.lblDiamPeekTube = new System.Windows.Forms.Label();
            this.lblMPa_mmol = new System.Windows.Forms.Label();
            this.rdbCouleurBleu = new System.Windows.Forms.RadioButton();
            this.txtLongPeekTubeJaune = new System.Windows.Forms.TextBox();
            this.rdbCouleurJaune = new System.Windows.Forms.RadioButton();
            this.rdbCouleurOrange = new System.Windows.Forms.RadioButton();
            this.txtLongPeekTubeOrange = new System.Windows.Forms.TextBox();
            this.txtMpa_mmol_Jaune = new System.Windows.Forms.TextBox();
            this.txtMpa_mmol_Bleu = new System.Windows.Forms.TextBox();
            this.txtMpa_mmol_Orange = new System.Windows.Forms.TextBox();
            this.txtDiamPeekTubeOrange = new System.Windows.Forms.TextBox();
            this.txtColorID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.grbConnexionArduino = new System.Windows.Forms.GroupBox();
            this.btnConnexionArduino = new System.Windows.Forms.Button();
            this.btnDeconnexionArduino = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.grbConnexion = new System.Windows.Forms.GroupBox();
            this.txtLoginIdPc = new System.Windows.Forms.TextBox();
            this.lblArduinoLogin = new System.Windows.Forms.Label();
            this.txtLoginArduino = new System.Windows.Forms.TextBox();
            this.lblConnexionOrdinateur = new System.Windows.Forms.Label();
            this.lblDateDuJour = new System.Windows.Forms.Label();
            this.lblUtiilisateur = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.tabCalibration = new System.Windows.Forms.TabPage();
            this.btnAjouterDataCalibration = new System.Windows.Forms.Button();
            this.btnCvOkCalibration = new System.Windows.Forms.Button();
            this.btnModifierDataCalibration = new System.Windows.Forms.Button();
            this.btnEffacerDataCalibration = new System.Windows.Forms.Button();
            this.txtLumiereStepCalibration = new System.Windows.Forms.TextBox();
            this.grbDiagrammeCalibration = new System.Windows.Forms.GroupBox();
            this.chtP2Calibration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtP1Calibration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStepCalibration = new System.Windows.Forms.Button();
            this.dgvDataCalibration = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExperimentation = new System.Windows.Forms.TabPage();
            this.btnAjouterDataExperience = new System.Windows.Forms.Button();
            this.btnModifierDataExperience = new System.Windows.Forms.Button();
            this.btnEffaceExperience = new System.Windows.Forms.Button();
            this.txtLumiereStepExperience = new System.Windows.Forms.TextBox();
            this.btnStepExperience = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dgvDataExperiementation = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPressureSensorCalibration = new System.Windows.Forms.TabPage();
            this.grbDiagrammePression = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grbP2 = new System.Windows.Forms.GroupBox();
            this.txtInterceptP2 = new System.Windows.Forms.TextBox();
            this.txtRcarrerP2 = new System.Windows.Forms.TextBox();
            this.txtSlopeP2 = new System.Windows.Forms.TextBox();
            this.lblInterceptP2 = new System.Windows.Forms.Label();
            this.lblRcarrerP2 = new System.Windows.Forms.Label();
            this.lblSlopeP2 = new System.Windows.Forms.Label();
            this.txtRcarreOkP2 = new System.Windows.Forms.TextBox();
            this.dgvP2Secondaire = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCvOkP2 = new System.Windows.Forms.TextBox();
            this.dgvP2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbP1 = new System.Windows.Forms.GroupBox();
            this.txtInterceptP1 = new System.Windows.Forms.TextBox();
            this.txtRcarrerP1 = new System.Windows.Forms.TextBox();
            this.txtSlopeP1 = new System.Windows.Forms.TextBox();
            this.lblInterceptP1 = new System.Windows.Forms.Label();
            this.lblRcarrerP1 = new System.Windows.Forms.Label();
            this.lblSlopeP1 = new System.Windows.Forms.Label();
            this.txtRcarreOkP1 = new System.Windows.Forms.TextBox();
            this.dgvP1Secondaire = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCvOkP1 = new System.Windows.Forms.TextBox();
            this.dgvP1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSingleKmeasurement = new System.Windows.Forms.TabPage();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.txtTotalResults = new System.Windows.Forms.TextBox();
            this.txtLast300sResults = new System.Windows.Forms.TextBox();
            this.txtGlobalResults = new System.Windows.Forms.TextBox();
            this.lblStepHuberValue = new System.Windows.Forms.Label();
            this.txtLeafAreaStemConductivityLast300s = new System.Windows.Forms.TextBox();
            this.txtLeafAreaStemConductivityTotal = new System.Windows.Forms.TextBox();
            this.lblLeafAreaStemConductivity = new System.Windows.Forms.Label();
            this.lblStepStemConductivity = new System.Windows.Forms.Label();
            this.txtStepStemConductivityLast300s = new System.Windows.Forms.TextBox();
            this.txtStepHuberValueLast300s = new System.Windows.Forms.TextBox();
            this.txtStepConductivityLast300s = new System.Windows.Forms.TextBox();
            this.txtStepStemConductivityTotal = new System.Windows.Forms.TextBox();
            this.txtStepHuberValueTotal = new System.Windows.Forms.TextBox();
            this.txtStepConductivityTotal = new System.Windows.Forms.TextBox();
            this.lblConductivity = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grbStep = new System.Windows.Forms.GroupBox();
            this.lblK25oCP3 = new System.Windows.Forms.Label();
            this.txtK25oCP3Last300s = new System.Windows.Forms.TextBox();
            this.txtKCorrectedP3Last300s = new System.Windows.Forms.TextBox();
            this.txtK25oCP3Total = new System.Windows.Forms.TextBox();
            this.txtKCorrectedP3Total = new System.Windows.Forms.TextBox();
            this.lblKCorrectedP3 = new System.Windows.Forms.Label();
            this.lblTempWaterBassin = new System.Windows.Forms.Label();
            this.txtTempWaterBassinLast300s = new System.Windows.Forms.TextBox();
            this.txtTempWaterBassinTotal = new System.Windows.Forms.TextBox();
            this.lblTempDownstream = new System.Windows.Forms.Label();
            this.lblResistancePeek = new System.Windows.Forms.Label();
            this.txtResistancePeekLast300s = new System.Windows.Forms.TextBox();
            this.txtAverageTempLast300s = new System.Windows.Forms.TextBox();
            this.txtResistancePeekTotal = new System.Windows.Forms.TextBox();
            this.txtAverageTempTotal = new System.Windows.Forms.TextBox();
            this.lblAverageTemp = new System.Windows.Forms.Label();
            this.lblTempUpstream = new System.Windows.Forms.Label();
            this.txtTempUpstreamLast300s = new System.Windows.Forms.TextBox();
            this.txtTempDownstreamLast300s = new System.Windows.Forms.TextBox();
            this.txtP3_P2StopcockLast300s = new System.Windows.Forms.TextBox();
            this.txtTempUpstreamTotal = new System.Windows.Forms.TextBox();
            this.txtTempDownstreamTotal = new System.Windows.Forms.TextBox();
            this.txtP3_P2StopcockTotal = new System.Windows.Forms.TextBox();
            this.lblP3_P2Stopcock = new System.Windows.Forms.Label();
            this.lblCvK = new System.Windows.Forms.Label();
            this.txtCvKLast300s = new System.Windows.Forms.TextBox();
            this.txtKrought_kgLast300s = new System.Windows.Forms.TextBox();
            this.txtCvKTotal = new System.Windows.Forms.TextBox();
            this.txtKrought_kgTotal = new System.Windows.Forms.TextBox();
            this.lblKrought_kg = new System.Windows.Forms.Label();
            this.lblP2bar = new System.Windows.Forms.Label();
            this.txtP2barLast300s = new System.Windows.Forms.TextBox();
            this.txtKrought_mmolLast300s = new System.Windows.Forms.TextBox();
            this.lblP1barLast300s = new System.Windows.Forms.TextBox();
            this.lblKrought_mmol = new System.Windows.Forms.Label();
            this.txtP2barTotal = new System.Windows.Forms.TextBox();
            this.txtKrought_mmolTotal = new System.Windows.Forms.TextBox();
            this.lblP1barTotal = new System.Windows.Forms.TextBox();
            this.lblP1bar = new System.Windows.Forms.Label();
            this.lblP2Validation = new System.Windows.Forms.Label();
            this.txtP2ValidationLast300s = new System.Windows.Forms.TextBox();
            this.txtAverageLast300s = new System.Windows.Forms.TextBox();
            this.txtP1ValidationLast300s = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtP2ValidationTotal = new System.Windows.Forms.TextBox();
            this.txtAverageTotal = new System.Windows.Forms.TextBox();
            this.txtP1ValidationTotal = new System.Windows.Forms.TextBox();
            this.txtTotalStep = new System.Windows.Forms.TextBox();
            this.txtLast300sStep = new System.Windows.Forms.TextBox();
            this.txtGlobalResultsStep = new System.Windows.Forms.TextBox();
            this.lblP1Validation = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.grbOverview = new System.Windows.Forms.GroupBox();
            this.btnStartMesure = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSeconde = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grbCalibrationOverview = new System.Windows.Forms.GroupBox();
            this.lblP2Calibration = new System.Windows.Forms.Label();
            this.lblP1Calibration = new System.Windows.Forms.Label();
            this.txtInterceptOverviewP2 = new System.Windows.Forms.TextBox();
            this.txtSlopeOverviewP2 = new System.Windows.Forms.TextBox();
            this.lblInterceptOverviewP2 = new System.Windows.Forms.Label();
            this.lblSlopeOverviewP2 = new System.Windows.Forms.Label();
            this.txtInterceptOverviewP1 = new System.Windows.Forms.TextBox();
            this.txtSlopeOverviewP1 = new System.Windows.Forms.TextBox();
            this.lblInterceptOverviewP1 = new System.Windows.Forms.Label();
            this.lblSlopeOverviewP1 = new System.Windows.Forms.Label();
            this.lblStability = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPresureValidation = new System.Windows.Forms.Label();
            this.lblOptimalPeekTube = new System.Windows.Forms.Label();
            this.txtPresureValidationTotal = new System.Windows.Forms.TextBox();
            this.txtOptimalPeekTubeLast300s = new System.Windows.Forms.TextBox();
            this.txtTimeValidation = new System.Windows.Forms.TextBox();
            this.txtPresureValidationLast300s = new System.Windows.Forms.TextBox();
            this.txtStabilityLast300s = new System.Windows.Forms.TextBox();
            this.txtOptimalPeekTubeTotal = new System.Windows.Forms.TextBox();
            this.txtStemConductivityLast300s = new System.Windows.Forms.TextBox();
            this.txtHuberValueLast300s = new System.Windows.Forms.TextBox();
            this.txtConductivityLast300s = new System.Windows.Forms.TextBox();
            this.txtLeafAreaLast300s = new System.Windows.Forms.TextBox();
            this.lblLeafArea = new System.Windows.Forms.Label();
            this.lblHuberValue = new System.Windows.Forms.Label();
            this.txtStemConductivityTotal = new System.Windows.Forms.TextBox();
            this.txtHuberValueTotal = new System.Windows.Forms.TextBox();
            this.txtConductivityTotal = new System.Windows.Forms.TextBox();
            this.txtLeafAreaTotal = new System.Windows.Forms.TextBox();
            this.txtTotalOverview = new System.Windows.Forms.TextBox();
            this.txtLast300sOverview = new System.Windows.Forms.TextBox();
            this.txtGlobalResultsOverview = new System.Windows.Forms.TextBox();
            this.lblCondutivityTotal = new System.Windows.Forms.Label();
            this.lblStemConductivity = new System.Windows.Forms.Label();
            this.lblValidation = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerminerExperience = new System.Windows.Forms.Button();
            this.grbEchantillon = new System.Windows.Forms.GroupBox();
            this.btnGestionEchantillon = new System.Windows.Forms.Button();
            this.btnValiderEchantillon = new System.Windows.Forms.Button();
            this.btnModifierEchantillon = new System.Windows.Forms.Button();
            this.txtSolutionPerfusion = new System.Windows.Forms.TextBox();
            this.txtLongueurSegment = new System.Windows.Forms.TextBox();
            this.lblDiametreSegment1 = new System.Windows.Forms.Label();
            this.lblLongueurSegment = new System.Windows.Forms.Label();
            this.lblDiametreSegment2 = new System.Windows.Forms.Label();
            this.txtPotentiels = new System.Windows.Forms.TextBox();
            this.txtDiametreSegment1 = new System.Windows.Forms.TextBox();
            this.txtDiametreSegment2 = new System.Windows.Forms.TextBox();
            this.cmbStressApplication = new System.Windows.Forms.ComboBox();
            this.txtAgeArbre = new System.Windows.Forms.TextBox();
            this.txtAgeEchantillon = new System.Windows.Forms.TextBox();
            this.txtEssence = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblStressApplication = new System.Windows.Forms.Label();
            this.lblPotentiels = new System.Windows.Forms.Label();
            this.lblAgeArbre = new System.Windows.Forms.Label();
            this.lblAgeEchantillon = new System.Windows.Forms.Label();
            this.lblSolulionPerfusion = new System.Windows.Forms.Label();
            this.lblEssence = new System.Windows.Forms.Label();
            this.grbExperience = new System.Windows.Forms.GroupBox();
            this.btnModifierExperience = new System.Windows.Forms.Button();
            this.btnValiderExperience = new System.Windows.Forms.Button();
            this.rtxbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDateExperience = new System.Windows.Forms.Label();
            this.txtXylem = new System.Windows.Forms.TextBox();
            this.txtDateExperience = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblXylem = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.grbMateriel = new System.Windows.Forms.GroupBox();
            this.btnValiderMateriel = new System.Windows.Forms.Button();
            this.btnModifierMateriel = new System.Windows.Forms.Button();
            this.lblID_Arduino = new System.Windows.Forms.Label();
            this.txtID_Arduino = new System.Windows.Forms.TextBox();
            this.lblNomPc = new System.Windows.Forms.Label();
            this.txtNomPc = new System.Windows.Forms.TextBox();
            this.lblID_drf = new System.Windows.Forms.Label();
            this.txtID_drf = new System.Windows.Forms.TextBox();
            this.txtID_Pc = new System.Windows.Forms.TextBox();
            this.lblID_Pc = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            grbPeekTube = new System.Windows.Forms.GroupBox();
            grbPeekTube.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.grbConnexionArduino.SuspendLayout();
            this.grbConnexion.SuspendLayout();
            this.tabCalibration.SuspendLayout();
            this.grbDiagrammeCalibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtP2Calibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtP1Calibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCalibration)).BeginInit();
            this.tabExperimentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExperiementation)).BeginInit();
            this.tabPressureSensorCalibration.SuspendLayout();
            this.grbDiagrammePression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grbP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2Secondaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2)).BeginInit();
            this.grbP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1Secondaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).BeginInit();
            this.tabSingleKmeasurement.SuspendLayout();
            this.grbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grbStep.SuspendLayout();
            this.grbOverview.SuspendLayout();
            this.grbCalibrationOverview.SuspendLayout();
            this.grbEchantillon.SuspendLayout();
            this.grbExperience.SuspendLayout();
            this.grbMateriel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPeekTube
            // 
            grbPeekTube.Controls.Add(this.btnEstValidePeekTube);
            grbPeekTube.Controls.Add(this.btnModifierPeekTube);
            grbPeekTube.Controls.Add(this.btnValiderPeekTube);
            grbPeekTube.Controls.Add(this.txtResistancePeekTube);
            grbPeekTube.Controls.Add(this.lblResistancePeekTube);
            grbPeekTube.Controls.Add(this.lblLongPeekTube);
            grbPeekTube.Controls.Add(this.txtDiamPeekTubeBleu);
            grbPeekTube.Controls.Add(this.txtDiamPeekTubeJaune);
            grbPeekTube.Controls.Add(this.txtLongPeekTubeBleu);
            grbPeekTube.Controls.Add(this.lblDiamPeekTube);
            grbPeekTube.Controls.Add(this.lblMPa_mmol);
            grbPeekTube.Controls.Add(this.rdbCouleurBleu);
            grbPeekTube.Controls.Add(this.txtLongPeekTubeJaune);
            grbPeekTube.Controls.Add(this.rdbCouleurJaune);
            grbPeekTube.Controls.Add(this.rdbCouleurOrange);
            grbPeekTube.Controls.Add(this.txtLongPeekTubeOrange);
            grbPeekTube.Controls.Add(this.txtMpa_mmol_Jaune);
            grbPeekTube.Controls.Add(this.txtMpa_mmol_Bleu);
            grbPeekTube.Controls.Add(this.txtMpa_mmol_Orange);
            grbPeekTube.Controls.Add(this.txtDiamPeekTubeOrange);
            grbPeekTube.Controls.Add(this.txtColorID);
            grbPeekTube.Location = new System.Drawing.Point(743, 874);
            grbPeekTube.Name = "grbPeekTube";
            grbPeekTube.Padding = new System.Windows.Forms.Padding(3, 3, 30, 3);
            grbPeekTube.Size = new System.Drawing.Size(512, 270);
            grbPeekTube.TabIndex = 27;
            grbPeekTube.TabStop = false;
            grbPeekTube.Text = "PeekTube";
            // 
            // btnEstValidePeekTube
            // 
            this.btnEstValidePeekTube.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEstValidePeekTube.Location = new System.Drawing.Point(135, 217);
            this.btnEstValidePeekTube.Name = "btnEstValidePeekTube";
            this.btnEstValidePeekTube.Size = new System.Drawing.Size(101, 44);
            this.btnEstValidePeekTube.TabIndex = 29;
            this.btnEstValidePeekTube.Text = "Est Valide";
            this.btnEstValidePeekTube.UseVisualStyleBackColor = false;
            // 
            // btnModifierPeekTube
            // 
            this.btnModifierPeekTube.Location = new System.Drawing.Point(243, 214);
            this.btnModifierPeekTube.Name = "btnModifierPeekTube";
            this.btnModifierPeekTube.Size = new System.Drawing.Size(121, 44);
            this.btnModifierPeekTube.TabIndex = 27;
            this.btnModifierPeekTube.Text = "Modifier";
            this.btnModifierPeekTube.UseVisualStyleBackColor = true;
            this.btnModifierPeekTube.Click += new System.EventHandler(this.btnModifierPeekTube_Click);
            // 
            // btnValiderPeekTube
            // 
            this.btnValiderPeekTube.Location = new System.Drawing.Point(370, 214);
            this.btnValiderPeekTube.Name = "btnValiderPeekTube";
            this.btnValiderPeekTube.Size = new System.Drawing.Size(121, 44);
            this.btnValiderPeekTube.TabIndex = 27;
            this.btnValiderPeekTube.Text = "Valider";
            this.btnValiderPeekTube.UseVisualStyleBackColor = true;
            this.btnValiderPeekTube.Click += new System.EventHandler(this.btnValiderPeekTube_Click);
            // 
            // txtResistancePeekTube
            // 
            this.txtResistancePeekTube.Location = new System.Drawing.Point(347, 28);
            this.txtResistancePeekTube.Name = "txtResistancePeekTube";
            this.txtResistancePeekTube.ReadOnly = true;
            this.txtResistancePeekTube.Size = new System.Drawing.Size(90, 26);
            this.txtResistancePeekTube.TabIndex = 25;
            // 
            // lblResistancePeekTube
            // 
            this.lblResistancePeekTube.AutoSize = true;
            this.lblResistancePeekTube.Location = new System.Drawing.Point(147, 28);
            this.lblResistancePeekTube.Name = "lblResistancePeekTube";
            this.lblResistancePeekTube.Size = new System.Drawing.Size(194, 20);
            this.lblResistancePeekTube.TabIndex = 24;
            this.lblResistancePeekTube.Text = "Resistance du peek tube :";
            // 
            // lblLongPeekTube
            // 
            this.lblLongPeekTube.AutoSize = true;
            this.lblLongPeekTube.Location = new System.Drawing.Point(401, 68);
            this.lblLongPeekTube.Name = "lblLongPeekTube";
            this.lblLongPeekTube.Size = new System.Drawing.Size(85, 20);
            this.lblLongPeekTube.TabIndex = 21;
            this.lblLongPeekTube.Text = "Long (mm)";
            // 
            // txtDiamPeekTubeBleu
            // 
            this.txtDiamPeekTubeBleu.Location = new System.Drawing.Point(283, 118);
            this.txtDiamPeekTubeBleu.Name = "txtDiamPeekTubeBleu";
            this.txtDiamPeekTubeBleu.ReadOnly = true;
            this.txtDiamPeekTubeBleu.Size = new System.Drawing.Size(90, 26);
            this.txtDiamPeekTubeBleu.TabIndex = 20;
            // 
            // txtDiamPeekTubeJaune
            // 
            this.txtDiamPeekTubeJaune.Location = new System.Drawing.Point(283, 150);
            this.txtDiamPeekTubeJaune.Name = "txtDiamPeekTubeJaune";
            this.txtDiamPeekTubeJaune.ReadOnly = true;
            this.txtDiamPeekTubeJaune.Size = new System.Drawing.Size(90, 26);
            this.txtDiamPeekTubeJaune.TabIndex = 18;
            // 
            // txtLongPeekTubeBleu
            // 
            this.txtLongPeekTubeBleu.Location = new System.Drawing.Point(401, 121);
            this.txtLongPeekTubeBleu.Name = "txtLongPeekTubeBleu";
            this.txtLongPeekTubeBleu.ReadOnly = true;
            this.txtLongPeekTubeBleu.Size = new System.Drawing.Size(90, 26);
            this.txtLongPeekTubeBleu.TabIndex = 19;
            // 
            // lblDiamPeekTube
            // 
            this.lblDiamPeekTube.AutoSize = true;
            this.lblDiamPeekTube.Location = new System.Drawing.Point(287, 66);
            this.lblDiamPeekTube.Name = "lblDiamPeekTube";
            this.lblDiamPeekTube.Size = new System.Drawing.Size(86, 20);
            this.lblDiamPeekTube.TabIndex = 13;
            this.lblDiamPeekTube.Text = "Diam (mm)";
            // 
            // lblMPa_mmol
            // 
            this.lblMPa_mmol.AutoSize = true;
            this.lblMPa_mmol.Location = new System.Drawing.Point(132, 66);
            this.lblMPa_mmol.Name = "lblMPa_mmol";
            this.lblMPa_mmol.Size = new System.Drawing.Size(119, 20);
            this.lblMPa_mmol.TabIndex = 12;
            this.lblMPa_mmol.Text = "(MPa mmol-1 s)";
            // 
            // rdbCouleurBleu
            // 
            this.rdbCouleurBleu.AutoSize = true;
            this.rdbCouleurBleu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rdbCouleurBleu.Location = new System.Drawing.Point(6, 119);
            this.rdbCouleurBleu.Name = "rdbCouleurBleu";
            this.rdbCouleurBleu.Padding = new System.Windows.Forms.Padding(0, 0, 58, 0);
            this.rdbCouleurBleu.Size = new System.Drawing.Size(124, 24);
            this.rdbCouleurBleu.TabIndex = 11;
            this.rdbCouleurBleu.TabStop = true;
            this.rdbCouleurBleu.Text = "Blue";
            this.rdbCouleurBleu.UseVisualStyleBackColor = false;
            this.rdbCouleurBleu.CheckedChanged += new System.EventHandler(this.rdbCouleurBleu_CheckedChanged);
            // 
            // txtLongPeekTubeJaune
            // 
            this.txtLongPeekTubeJaune.Location = new System.Drawing.Point(401, 153);
            this.txtLongPeekTubeJaune.Name = "txtLongPeekTubeJaune";
            this.txtLongPeekTubeJaune.ReadOnly = true;
            this.txtLongPeekTubeJaune.Size = new System.Drawing.Size(90, 26);
            this.txtLongPeekTubeJaune.TabIndex = 17;
            // 
            // rdbCouleurJaune
            // 
            this.rdbCouleurJaune.AutoSize = true;
            this.rdbCouleurJaune.BackColor = System.Drawing.Color.Yellow;
            this.rdbCouleurJaune.Location = new System.Drawing.Point(6, 149);
            this.rdbCouleurJaune.Name = "rdbCouleurJaune";
            this.rdbCouleurJaune.Padding = new System.Windows.Forms.Padding(0, 0, 43, 0);
            this.rdbCouleurJaune.Size = new System.Drawing.Size(123, 24);
            this.rdbCouleurJaune.TabIndex = 10;
            this.rdbCouleurJaune.TabStop = true;
            this.rdbCouleurJaune.Text = "Yellow";
            this.rdbCouleurJaune.UseVisualStyleBackColor = false;
            this.rdbCouleurJaune.CheckedChanged += new System.EventHandler(this.rdbCouleurJaune_CheckedChanged);
            // 
            // rdbCouleurOrange
            // 
            this.rdbCouleurOrange.AutoSize = true;
            this.rdbCouleurOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.rdbCouleurOrange.Location = new System.Drawing.Point(6, 89);
            this.rdbCouleurOrange.Name = "rdbCouleurOrange";
            this.rdbCouleurOrange.Padding = new System.Windows.Forms.Padding(0, 0, 37, 0);
            this.rdbCouleurOrange.Size = new System.Drawing.Size(124, 24);
            this.rdbCouleurOrange.TabIndex = 8;
            this.rdbCouleurOrange.TabStop = true;
            this.rdbCouleurOrange.Text = "Orange";
            this.rdbCouleurOrange.UseVisualStyleBackColor = false;
            this.rdbCouleurOrange.CheckedChanged += new System.EventHandler(this.rdbCouleurOrange_CheckedChanged);
            // 
            // txtLongPeekTubeOrange
            // 
            this.txtLongPeekTubeOrange.Location = new System.Drawing.Point(401, 89);
            this.txtLongPeekTubeOrange.Name = "txtLongPeekTubeOrange";
            this.txtLongPeekTubeOrange.ReadOnly = true;
            this.txtLongPeekTubeOrange.Size = new System.Drawing.Size(90, 26);
            this.txtLongPeekTubeOrange.TabIndex = 14;
            // 
            // txtMpa_mmol_Jaune
            // 
            this.txtMpa_mmol_Jaune.Location = new System.Drawing.Point(135, 149);
            this.txtMpa_mmol_Jaune.Name = "txtMpa_mmol_Jaune";
            this.txtMpa_mmol_Jaune.ReadOnly = true;
            this.txtMpa_mmol_Jaune.Size = new System.Drawing.Size(112, 26);
            this.txtMpa_mmol_Jaune.TabIndex = 4;
            this.txtMpa_mmol_Jaune.Text = "0.62241528";
            this.txtMpa_mmol_Jaune.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMpa_mmol_Bleu
            // 
            this.txtMpa_mmol_Bleu.Location = new System.Drawing.Point(135, 119);
            this.txtMpa_mmol_Bleu.Name = "txtMpa_mmol_Bleu";
            this.txtMpa_mmol_Bleu.ReadOnly = true;
            this.txtMpa_mmol_Bleu.Size = new System.Drawing.Size(112, 26);
            this.txtMpa_mmol_Bleu.TabIndex = 3;
            this.txtMpa_mmol_Bleu.Text = "0.1905205";
            this.txtMpa_mmol_Bleu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMpa_mmol_Orange
            // 
            this.txtMpa_mmol_Orange.Location = new System.Drawing.Point(136, 89);
            this.txtMpa_mmol_Orange.Name = "txtMpa_mmol_Orange";
            this.txtMpa_mmol_Orange.ReadOnly = true;
            this.txtMpa_mmol_Orange.Size = new System.Drawing.Size(112, 26);
            this.txtMpa_mmol_Orange.TabIndex = 2;
            this.txtMpa_mmol_Orange.Text = "0.015";
            this.txtMpa_mmol_Orange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiamPeekTubeOrange
            // 
            this.txtDiamPeekTubeOrange.Location = new System.Drawing.Point(283, 89);
            this.txtDiamPeekTubeOrange.Name = "txtDiamPeekTubeOrange";
            this.txtDiamPeekTubeOrange.ReadOnly = true;
            this.txtDiamPeekTubeOrange.Size = new System.Drawing.Size(90, 26);
            this.txtDiamPeekTubeOrange.TabIndex = 1;
            // 
            // txtColorID
            // 
            this.txtColorID.BackColor = System.Drawing.Color.LightGray;
            this.txtColorID.Location = new System.Drawing.Point(6, 25);
            this.txtColorID.Name = "txtColorID";
            this.txtColorID.Size = new System.Drawing.Size(126, 26);
            this.txtColorID.TabIndex = 0;
            this.txtColorID.Text = "Color ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2229, 856);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classeur";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabLogin);
            this.tabPrincipal.Controls.Add(this.tabCalibration);
            this.tabPrincipal.Controls.Add(this.tabExperimentation);
            this.tabPrincipal.Controls.Add(this.tabPressureSensorCalibration);
            this.tabPrincipal.Controls.Add(this.tabSingleKmeasurement);
            this.tabPrincipal.Location = new System.Drawing.Point(6, 25);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(2217, 823);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.grbConnexionArduino);
            this.tabLogin.Controls.Add(this.grbConnexion);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(2209, 790);
            this.tabLogin.TabIndex = 4;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // grbConnexionArduino
            // 
            this.grbConnexionArduino.Controls.Add(this.btnConnexionArduino);
            this.grbConnexionArduino.Controls.Add(this.btnDeconnexionArduino);
            this.grbConnexionArduino.Controls.Add(this.cmbPorts);
            this.grbConnexionArduino.Location = new System.Drawing.Point(399, 9);
            this.grbConnexionArduino.Name = "grbConnexionArduino";
            this.grbConnexionArduino.Size = new System.Drawing.Size(387, 778);
            this.grbConnexionArduino.TabIndex = 40;
            this.grbConnexionArduino.TabStop = false;
            this.grbConnexionArduino.Text = "Connexion Arduino";
            // 
            // btnConnexionArduino
            // 
            this.btnConnexionArduino.Location = new System.Drawing.Point(210, 114);
            this.btnConnexionArduino.Name = "btnConnexionArduino";
            this.btnConnexionArduino.Size = new System.Drawing.Size(137, 38);
            this.btnConnexionArduino.TabIndex = 2;
            this.btnConnexionArduino.Text = "Connexion";
            this.btnConnexionArduino.UseVisualStyleBackColor = true;
            this.btnConnexionArduino.Click += new System.EventHandler(this.btnConnexionArduino_Click);
            // 
            // btnDeconnexionArduino
            // 
            this.btnDeconnexionArduino.Location = new System.Drawing.Point(88, 114);
            this.btnDeconnexionArduino.Name = "btnDeconnexionArduino";
            this.btnDeconnexionArduino.Size = new System.Drawing.Size(116, 38);
            this.btnDeconnexionArduino.TabIndex = 1;
            this.btnDeconnexionArduino.Text = "Déconnexion";
            this.btnDeconnexionArduino.UseVisualStyleBackColor = true;
            this.btnDeconnexionArduino.Click += new System.EventHandler(this.btnDeconnexionArduino_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(88, 32);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(259, 28);
            this.cmbPorts.TabIndex = 0;
            this.cmbPorts.SelectedIndexChanged += new System.EventHandler(this.cmbPorts_SelectedIndexChanged);
            // 
            // grbConnexion
            // 
            this.grbConnexion.Controls.Add(this.txtLoginIdPc);
            this.grbConnexion.Controls.Add(this.lblArduinoLogin);
            this.grbConnexion.Controls.Add(this.txtLoginArduino);
            this.grbConnexion.Controls.Add(this.lblConnexionOrdinateur);
            this.grbConnexion.Controls.Add(this.lblDateDuJour);
            this.grbConnexion.Controls.Add(this.lblUtiilisateur);
            this.grbConnexion.Controls.Add(this.btnConnexion);
            this.grbConnexion.Controls.Add(this.lblDate);
            this.grbConnexion.Controls.Add(this.txtUtilisateur);
            this.grbConnexion.Location = new System.Drawing.Point(6, 6);
            this.grbConnexion.Name = "grbConnexion";
            this.grbConnexion.Size = new System.Drawing.Size(387, 778);
            this.grbConnexion.TabIndex = 39;
            this.grbConnexion.TabStop = false;
            this.grbConnexion.Text = "Connexion";
            // 
            // txtLoginIdPc
            // 
            this.txtLoginIdPc.Location = new System.Drawing.Point(158, 114);
            this.txtLoginIdPc.Name = "txtLoginIdPc";
            this.txtLoginIdPc.Size = new System.Drawing.Size(184, 26);
            this.txtLoginIdPc.TabIndex = 42;
            this.txtLoginIdPc.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginIdPc_Validating);
            // 
            // lblArduinoLogin
            // 
            this.lblArduinoLogin.AutoSize = true;
            this.lblArduinoLogin.Location = new System.Drawing.Point(61, 76);
            this.lblArduinoLogin.Name = "lblArduinoLogin";
            this.lblArduinoLogin.Size = new System.Drawing.Size(90, 20);
            this.lblArduinoLogin.TabIndex = 39;
            this.lblArduinoLogin.Text = "Id Arduino :";
            // 
            // txtLoginArduino
            // 
            this.txtLoginArduino.Location = new System.Drawing.Point(158, 73);
            this.txtLoginArduino.Name = "txtLoginArduino";
            this.txtLoginArduino.Size = new System.Drawing.Size(184, 26);
            this.txtLoginArduino.TabIndex = 40;
            this.txtLoginArduino.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginArduino_Validating);
            // 
            // lblConnexionOrdinateur
            // 
            this.lblConnexionOrdinateur.AutoSize = true;
            this.lblConnexionOrdinateur.Location = new System.Drawing.Point(98, 117);
            this.lblConnexionOrdinateur.Name = "lblConnexionOrdinateur";
            this.lblConnexionOrdinateur.Size = new System.Drawing.Size(53, 20);
            this.lblConnexionOrdinateur.TabIndex = 41;
            this.lblConnexionOrdinateur.Text = "Id Pc :";
            // 
            // lblDateDuJour
            // 
            this.lblDateDuJour.AutoSize = true;
            this.lblDateDuJour.Location = new System.Drawing.Point(154, 164);
            this.lblDateDuJour.Name = "lblDateDuJour";
            this.lblDateDuJour.Size = new System.Drawing.Size(44, 20);
            this.lblDateDuJour.TabIndex = 38;
            this.lblDateDuJour.Text = "Date";
            // 
            // lblUtiilisateur
            // 
            this.lblUtiilisateur.AutoSize = true;
            this.lblUtiilisateur.Location = new System.Drawing.Point(40, 35);
            this.lblUtiilisateur.Name = "lblUtiilisateur";
            this.lblUtiilisateur.Size = new System.Drawing.Size(111, 20);
            this.lblUtiilisateur.TabIndex = 31;
            this.lblUtiilisateur.Text = "Identifiant drf :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(236, 203);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(106, 42);
            this.btnConnexion.TabIndex = 32;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(94, 164);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 20);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date :";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(158, 32);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(184, 26);
            this.txtUtilisateur.TabIndex = 33;
            this.txtUtilisateur.Validating += new System.ComponentModel.CancelEventHandler(this.txtUtilisateur_Validating);
            // 
            // tabCalibration
            // 
            this.tabCalibration.Controls.Add(this.btnAjouterDataCalibration);
            this.tabCalibration.Controls.Add(this.btnCvOkCalibration);
            this.tabCalibration.Controls.Add(this.btnModifierDataCalibration);
            this.tabCalibration.Controls.Add(this.btnEffacerDataCalibration);
            this.tabCalibration.Controls.Add(this.txtLumiereStepCalibration);
            this.tabCalibration.Controls.Add(this.grbDiagrammeCalibration);
            this.tabCalibration.Controls.Add(this.btnStepCalibration);
            this.tabCalibration.Controls.Add(this.dgvDataCalibration);
            this.tabCalibration.Location = new System.Drawing.Point(4, 29);
            this.tabCalibration.Name = "tabCalibration";
            this.tabCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalibration.Size = new System.Drawing.Size(2209, 790);
            this.tabCalibration.TabIndex = 0;
            this.tabCalibration.Text = "Données Calibration";
            this.tabCalibration.UseVisualStyleBackColor = true;
            // 
            // btnAjouterDataCalibration
            // 
            this.btnAjouterDataCalibration.Location = new System.Drawing.Point(1205, 731);
            this.btnAjouterDataCalibration.Name = "btnAjouterDataCalibration";
            this.btnAjouterDataCalibration.Size = new System.Drawing.Size(113, 53);
            this.btnAjouterDataCalibration.TabIndex = 7;
            this.btnAjouterDataCalibration.Text = "Ajouter des données";
            this.btnAjouterDataCalibration.UseVisualStyleBackColor = true;
            // 
            // btnCvOkCalibration
            // 
            this.btnCvOkCalibration.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCvOkCalibration.Location = new System.Drawing.Point(1095, 731);
            this.btnCvOkCalibration.Name = "btnCvOkCalibration";
            this.btnCvOkCalibration.Size = new System.Drawing.Size(104, 52);
            this.btnCvOkCalibration.TabIndex = 5;
            this.btnCvOkCalibration.Text = "Cv OK";
            this.btnCvOkCalibration.UseVisualStyleBackColor = false;
            // 
            // btnModifierDataCalibration
            // 
            this.btnModifierDataCalibration.Location = new System.Drawing.Point(1324, 731);
            this.btnModifierDataCalibration.Name = "btnModifierDataCalibration";
            this.btnModifierDataCalibration.Size = new System.Drawing.Size(113, 53);
            this.btnModifierDataCalibration.TabIndex = 6;
            this.btnModifierDataCalibration.Text = "Modifier les données";
            this.btnModifierDataCalibration.UseVisualStyleBackColor = true;
            // 
            // btnEffacerDataCalibration
            // 
            this.btnEffacerDataCalibration.Location = new System.Drawing.Point(1443, 731);
            this.btnEffacerDataCalibration.Name = "btnEffacerDataCalibration";
            this.btnEffacerDataCalibration.Size = new System.Drawing.Size(113, 53);
            this.btnEffacerDataCalibration.TabIndex = 5;
            this.btnEffacerDataCalibration.Text = "Effacer les données";
            this.btnEffacerDataCalibration.UseVisualStyleBackColor = true;
            // 
            // txtLumiereStepCalibration
            // 
            this.txtLumiereStepCalibration.BackColor = System.Drawing.Color.Red;
            this.txtLumiereStepCalibration.Location = new System.Drawing.Point(1562, 699);
            this.txtLumiereStepCalibration.Name = "txtLumiereStepCalibration";
            this.txtLumiereStepCalibration.Size = new System.Drawing.Size(118, 26);
            this.txtLumiereStepCalibration.TabIndex = 4;
            // 
            // grbDiagrammeCalibration
            // 
            this.grbDiagrammeCalibration.Controls.Add(this.chtP2Calibration);
            this.grbDiagrammeCalibration.Controls.Add(this.chtP1Calibration);
            this.grbDiagrammeCalibration.Location = new System.Drawing.Point(1686, 6);
            this.grbDiagrammeCalibration.Name = "grbDiagrammeCalibration";
            this.grbDiagrammeCalibration.Size = new System.Drawing.Size(499, 777);
            this.grbDiagrammeCalibration.TabIndex = 3;
            this.grbDiagrammeCalibration.TabStop = false;
            this.grbDiagrammeCalibration.Text = "Diagramme";
            // 
            // chtP2Calibration
            // 
            chartArea15.Name = "ChartArea1";
            this.chtP2Calibration.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chtP2Calibration.Legends.Add(legend15);
            this.chtP2Calibration.Location = new System.Drawing.Point(21, 419);
            this.chtP2Calibration.Name = "chtP2Calibration";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chtP2Calibration.Series.Add(series15);
            this.chtP2Calibration.Size = new System.Drawing.Size(446, 300);
            this.chtP2Calibration.TabIndex = 32;
            this.chtP2Calibration.Text = "chart2";
            // 
            // chtP1Calibration
            // 
            chartArea16.Name = "ChartArea1";
            this.chtP1Calibration.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chtP1Calibration.Legends.Add(legend16);
            this.chtP1Calibration.Location = new System.Drawing.Point(21, 40);
            this.chtP1Calibration.Name = "chtP1Calibration";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chtP1Calibration.Series.Add(series16);
            this.chtP1Calibration.Size = new System.Drawing.Size(446, 300);
            this.chtP1Calibration.TabIndex = 31;
            this.chtP1Calibration.Text = "chart1";
            // 
            // btnStepCalibration
            // 
            this.btnStepCalibration.Location = new System.Drawing.Point(1562, 731);
            this.btnStepCalibration.Name = "btnStepCalibration";
            this.btnStepCalibration.Size = new System.Drawing.Size(118, 52);
            this.btnStepCalibration.TabIndex = 2;
            this.btnStepCalibration.Text = "Step";
            this.btnStepCalibration.UseVisualStyleBackColor = true;
            // 
            // dgvDataCalibration
            // 
            this.dgvDataCalibration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCalibration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvDataCalibration.Location = new System.Drawing.Point(6, 6);
            this.dgvDataCalibration.Name = "dgvDataCalibration";
            this.dgvDataCalibration.RowHeadersWidth = 62;
            this.dgvDataCalibration.RowTemplate.Height = 28;
            this.dgvDataCalibration.Size = new System.Drawing.Size(1674, 678);
            this.dgvDataCalibration.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Step";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "p1_slope";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "p1_intercept";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "p1_R2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "p2_slope";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "p2_intercept";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "p2_R2";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "t1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "t2";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "t3";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "temps_calib";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // tabExperimentation
            // 
            this.tabExperimentation.Controls.Add(this.btnAjouterDataExperience);
            this.tabExperimentation.Controls.Add(this.btnModifierDataExperience);
            this.tabExperimentation.Controls.Add(this.btnEffaceExperience);
            this.tabExperimentation.Controls.Add(this.txtLumiereStepExperience);
            this.tabExperimentation.Controls.Add(this.btnStepExperience);
            this.tabExperimentation.Controls.Add(this.pictureBox6);
            this.tabExperimentation.Controls.Add(this.dgvDataExperiementation);
            this.tabExperimentation.Location = new System.Drawing.Point(4, 29);
            this.tabExperimentation.Name = "tabExperimentation";
            this.tabExperimentation.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperimentation.Size = new System.Drawing.Size(2209, 790);
            this.tabExperimentation.TabIndex = 1;
            this.tabExperimentation.Text = "Données expérimentation";
            this.tabExperimentation.UseVisualStyleBackColor = true;
            // 
            // btnAjouterDataExperience
            // 
            this.btnAjouterDataExperience.Location = new System.Drawing.Point(1731, 411);
            this.btnAjouterDataExperience.Name = "btnAjouterDataExperience";
            this.btnAjouterDataExperience.Size = new System.Drawing.Size(118, 53);
            this.btnAjouterDataExperience.TabIndex = 13;
            this.btnAjouterDataExperience.Text = "Ajouter des données";
            this.btnAjouterDataExperience.UseVisualStyleBackColor = true;
            // 
            // btnModifierDataExperience
            // 
            this.btnModifierDataExperience.Location = new System.Drawing.Point(1731, 470);
            this.btnModifierDataExperience.Name = "btnModifierDataExperience";
            this.btnModifierDataExperience.Size = new System.Drawing.Size(118, 53);
            this.btnModifierDataExperience.TabIndex = 12;
            this.btnModifierDataExperience.Text = "Modifier les données";
            this.btnModifierDataExperience.UseVisualStyleBackColor = true;
            // 
            // btnEffaceExperience
            // 
            this.btnEffaceExperience.Location = new System.Drawing.Point(1731, 529);
            this.btnEffaceExperience.Name = "btnEffaceExperience";
            this.btnEffaceExperience.Size = new System.Drawing.Size(118, 53);
            this.btnEffaceExperience.TabIndex = 11;
            this.btnEffaceExperience.Text = "Effacer les données";
            this.btnEffaceExperience.UseVisualStyleBackColor = true;
            // 
            // txtLumiereStepExperience
            // 
            this.txtLumiereStepExperience.BackColor = System.Drawing.Color.Red;
            this.txtLumiereStepExperience.Location = new System.Drawing.Point(1731, 321);
            this.txtLumiereStepExperience.Name = "txtLumiereStepExperience";
            this.txtLumiereStepExperience.Size = new System.Drawing.Size(118, 26);
            this.txtLumiereStepExperience.TabIndex = 9;
            // 
            // btnStepExperience
            // 
            this.btnStepExperience.Location = new System.Drawing.Point(1731, 353);
            this.btnStepExperience.Name = "btnStepExperience";
            this.btnStepExperience.Size = new System.Drawing.Size(118, 52);
            this.btnStepExperience.TabIndex = 8;
            this.btnStepExperience.Text = "Step";
            this.btnStepExperience.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Interface.Properties.Resources.test2;
            this.pictureBox6.Location = new System.Drawing.Point(1731, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(460, 309);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // dgvDataExperiementation
            // 
            this.dgvDataExperiementation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataExperiementation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDataExperiementation.Location = new System.Drawing.Point(11, 6);
            this.dgvDataExperiementation.Name = "dgvDataExperiementation";
            this.dgvDataExperiementation.RowHeadersWidth = 62;
            this.dgvDataExperiementation.RowTemplate.Height = 28;
            this.dgvDataExperiementation.Size = new System.Drawing.Size(1714, 778);
            this.dgvDataExperiementation.TabIndex = 0;
            // 
            // Step
            // 
            this.Step.HeaderText = "Step";
            this.Step.MinimumWidth = 8;
            this.Step.Name = "Step";
            this.Step.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "p1_slope";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "p1_intercept";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "p1_R2";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "p2_slope";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "p2_intercept";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "p2_R2";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "t1";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "t2";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "t3";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "temps_calib";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // tabPressureSensorCalibration
            // 
            this.tabPressureSensorCalibration.Controls.Add(this.grbDiagrammePression);
            this.tabPressureSensorCalibration.Controls.Add(this.grbP2);
            this.tabPressureSensorCalibration.Controls.Add(this.grbP1);
            this.tabPressureSensorCalibration.Location = new System.Drawing.Point(4, 29);
            this.tabPressureSensorCalibration.Name = "tabPressureSensorCalibration";
            this.tabPressureSensorCalibration.Size = new System.Drawing.Size(2209, 790);
            this.tabPressureSensorCalibration.TabIndex = 2;
            this.tabPressureSensorCalibration.Text = "PressureSensorCalibration";
            this.tabPressureSensorCalibration.UseVisualStyleBackColor = true;
            // 
            // grbDiagrammePression
            // 
            this.grbDiagrammePression.Controls.Add(this.pictureBox1);
            this.grbDiagrammePression.Controls.Add(this.pictureBox5);
            this.grbDiagrammePression.Location = new System.Drawing.Point(1665, 6);
            this.grbDiagrammePression.Name = "grbDiagrammePression";
            this.grbDiagrammePression.Size = new System.Drawing.Size(499, 768);
            this.grbDiagrammePression.TabIndex = 20;
            this.grbDiagrammePression.TabStop = false;
            this.grbDiagrammePression.Text = "Diagramme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(57, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 366);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Interface.Properties.Resources.test;
            this.pictureBox5.Location = new System.Drawing.Point(57, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(385, 375);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // grbP2
            // 
            this.grbP2.Controls.Add(this.txtInterceptP2);
            this.grbP2.Controls.Add(this.txtRcarrerP2);
            this.grbP2.Controls.Add(this.txtSlopeP2);
            this.grbP2.Controls.Add(this.lblInterceptP2);
            this.grbP2.Controls.Add(this.lblRcarrerP2);
            this.grbP2.Controls.Add(this.lblSlopeP2);
            this.grbP2.Controls.Add(this.txtRcarreOkP2);
            this.grbP2.Controls.Add(this.dgvP2Secondaire);
            this.grbP2.Controls.Add(this.txtCvOkP2);
            this.grbP2.Controls.Add(this.dgvP2);
            this.grbP2.Location = new System.Drawing.Point(834, 6);
            this.grbP2.Name = "grbP2";
            this.grbP2.Size = new System.Drawing.Size(825, 708);
            this.grbP2.TabIndex = 2;
            this.grbP2.TabStop = false;
            this.grbP2.Text = "P2";
            // 
            // txtInterceptP2
            // 
            this.txtInterceptP2.Location = new System.Drawing.Point(700, 482);
            this.txtInterceptP2.Name = "txtInterceptP2";
            this.txtInterceptP2.Size = new System.Drawing.Size(116, 26);
            this.txtInterceptP2.TabIndex = 19;
            this.txtInterceptP2.Text = "4.68024E-05";
            // 
            // txtRcarrerP2
            // 
            this.txtRcarrerP2.Location = new System.Drawing.Point(700, 519);
            this.txtRcarrerP2.Name = "txtRcarrerP2";
            this.txtRcarrerP2.Size = new System.Drawing.Size(116, 26);
            this.txtRcarrerP2.TabIndex = 18;
            this.txtRcarrerP2.Text = "0.999900406";
            // 
            // txtSlopeP2
            // 
            this.txtSlopeP2.Location = new System.Drawing.Point(700, 447);
            this.txtSlopeP2.Name = "txtSlopeP2";
            this.txtSlopeP2.Size = new System.Drawing.Size(116, 26);
            this.txtSlopeP2.TabIndex = 12;
            this.txtSlopeP2.Text = "6.24097R-06";
            // 
            // lblInterceptP2
            // 
            this.lblInterceptP2.AutoSize = true;
            this.lblInterceptP2.Location = new System.Drawing.Point(609, 488);
            this.lblInterceptP2.Name = "lblInterceptP2";
            this.lblInterceptP2.Size = new System.Drawing.Size(85, 20);
            this.lblInterceptP2.TabIndex = 17;
            this.lblInterceptP2.Text = "Intercept : ";
            // 
            // lblRcarrerP2
            // 
            this.lblRcarrerP2.AutoSize = true;
            this.lblRcarrerP2.Location = new System.Drawing.Point(656, 525);
            this.lblRcarrerP2.Name = "lblRcarrerP2";
            this.lblRcarrerP2.Size = new System.Drawing.Size(38, 20);
            this.lblRcarrerP2.TabIndex = 16;
            this.lblRcarrerP2.Text = "R² : ";
            // 
            // lblSlopeP2
            // 
            this.lblSlopeP2.AutoSize = true;
            this.lblSlopeP2.Location = new System.Drawing.Point(632, 450);
            this.lblSlopeP2.Name = "lblSlopeP2";
            this.lblSlopeP2.Size = new System.Drawing.Size(62, 20);
            this.lblSlopeP2.TabIndex = 15;
            this.lblSlopeP2.Text = "Slope : ";
            // 
            // txtRcarreOkP2
            // 
            this.txtRcarreOkP2.BackColor = System.Drawing.Color.Lime;
            this.txtRcarreOkP2.Location = new System.Drawing.Point(700, 409);
            this.txtRcarreOkP2.Name = "txtRcarreOkP2";
            this.txtRcarreOkP2.Size = new System.Drawing.Size(116, 26);
            this.txtRcarreOkP2.TabIndex = 14;
            this.txtRcarreOkP2.Text = "R² OK (>0.999)";
            // 
            // dgvP2Secondaire
            // 
            this.dgvP2Secondaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP2Secondaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.dgvP2Secondaire.Location = new System.Drawing.Point(6, 377);
            this.dgvP2Secondaire.Name = "dgvP2Secondaire";
            this.dgvP2Secondaire.RowHeadersWidth = 62;
            this.dgvP2Secondaire.RowTemplate.Height = 28;
            this.dgvP2Secondaire.Size = new System.Drawing.Size(512, 325);
            this.dgvP2Secondaire.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Step";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "PrUnits";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Bar";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 150;
            // 
            // txtCvOkP2
            // 
            this.txtCvOkP2.BackColor = System.Drawing.Color.Lime;
            this.txtCvOkP2.Location = new System.Drawing.Point(700, 377);
            this.txtCvOkP2.Name = "txtCvOkP2";
            this.txtCvOkP2.Size = new System.Drawing.Size(116, 26);
            this.txtCvOkP2.TabIndex = 11;
            this.txtCvOkP2.Text = "CV OK (<0.05)";
            // 
            // dgvP2
            // 
            this.dgvP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvP2.Location = new System.Drawing.Point(6, 36);
            this.dgvP2.Name = "dgvP2";
            this.dgvP2.RowHeadersWidth = 62;
            this.dgvP2.RowTemplate.Height = 28;
            this.dgvP2.Size = new System.Drawing.Size(810, 316);
            this.dgvP2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Step";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Heigh (cm)";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Average";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "StdDev";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "CV";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // grbP1
            // 
            this.grbP1.Controls.Add(this.txtInterceptP1);
            this.grbP1.Controls.Add(this.txtRcarrerP1);
            this.grbP1.Controls.Add(this.txtSlopeP1);
            this.grbP1.Controls.Add(this.lblInterceptP1);
            this.grbP1.Controls.Add(this.lblRcarrerP1);
            this.grbP1.Controls.Add(this.lblSlopeP1);
            this.grbP1.Controls.Add(this.txtRcarreOkP1);
            this.grbP1.Controls.Add(this.dgvP1Secondaire);
            this.grbP1.Controls.Add(this.txtCvOkP1);
            this.grbP1.Controls.Add(this.dgvP1);
            this.grbP1.Location = new System.Drawing.Point(3, 6);
            this.grbP1.Name = "grbP1";
            this.grbP1.Size = new System.Drawing.Size(825, 708);
            this.grbP1.TabIndex = 1;
            this.grbP1.TabStop = false;
            this.grbP1.Text = "P1";
            // 
            // txtInterceptP1
            // 
            this.txtInterceptP1.Location = new System.Drawing.Point(700, 482);
            this.txtInterceptP1.Name = "txtInterceptP1";
            this.txtInterceptP1.Size = new System.Drawing.Size(116, 26);
            this.txtInterceptP1.TabIndex = 10;
            this.txtInterceptP1.Text = "4.68024E-05";
            // 
            // txtRcarrerP1
            // 
            this.txtRcarrerP1.Location = new System.Drawing.Point(700, 519);
            this.txtRcarrerP1.Name = "txtRcarrerP1";
            this.txtRcarrerP1.Size = new System.Drawing.Size(116, 26);
            this.txtRcarrerP1.TabIndex = 9;
            this.txtRcarrerP1.Text = "0.999900406";
            // 
            // txtSlopeP1
            // 
            this.txtSlopeP1.Location = new System.Drawing.Point(700, 447);
            this.txtSlopeP1.Name = "txtSlopeP1";
            this.txtSlopeP1.Size = new System.Drawing.Size(116, 26);
            this.txtSlopeP1.TabIndex = 3;
            this.txtSlopeP1.Text = "6.24097R-06";
            // 
            // lblInterceptP1
            // 
            this.lblInterceptP1.AutoSize = true;
            this.lblInterceptP1.Location = new System.Drawing.Point(609, 488);
            this.lblInterceptP1.Name = "lblInterceptP1";
            this.lblInterceptP1.Size = new System.Drawing.Size(85, 20);
            this.lblInterceptP1.TabIndex = 7;
            this.lblInterceptP1.Text = "Intercept : ";
            // 
            // lblRcarrerP1
            // 
            this.lblRcarrerP1.AutoSize = true;
            this.lblRcarrerP1.Location = new System.Drawing.Point(656, 525);
            this.lblRcarrerP1.Name = "lblRcarrerP1";
            this.lblRcarrerP1.Size = new System.Drawing.Size(38, 20);
            this.lblRcarrerP1.TabIndex = 6;
            this.lblRcarrerP1.Text = "R² : ";
            // 
            // lblSlopeP1
            // 
            this.lblSlopeP1.AutoSize = true;
            this.lblSlopeP1.Location = new System.Drawing.Point(632, 450);
            this.lblSlopeP1.Name = "lblSlopeP1";
            this.lblSlopeP1.Size = new System.Drawing.Size(62, 20);
            this.lblSlopeP1.TabIndex = 5;
            this.lblSlopeP1.Text = "Slope : ";
            // 
            // txtRcarreOkP1
            // 
            this.txtRcarreOkP1.BackColor = System.Drawing.Color.Lime;
            this.txtRcarreOkP1.Location = new System.Drawing.Point(700, 409);
            this.txtRcarreOkP1.Name = "txtRcarreOkP1";
            this.txtRcarreOkP1.Size = new System.Drawing.Size(116, 26);
            this.txtRcarreOkP1.TabIndex = 4;
            this.txtRcarreOkP1.Text = "R² OK (>0.999)";
            // 
            // dgvP1Secondaire
            // 
            this.dgvP1Secondaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP1Secondaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.dgvP1Secondaire.Location = new System.Drawing.Point(6, 377);
            this.dgvP1Secondaire.Name = "dgvP1Secondaire";
            this.dgvP1Secondaire.RowHeadersWidth = 62;
            this.dgvP1Secondaire.RowTemplate.Height = 28;
            this.dgvP1Secondaire.Size = new System.Drawing.Size(512, 325);
            this.dgvP1Secondaire.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Step";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "PrUnits";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Bar";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // txtCvOkP1
            // 
            this.txtCvOkP1.BackColor = System.Drawing.Color.Lime;
            this.txtCvOkP1.Location = new System.Drawing.Point(700, 377);
            this.txtCvOkP1.Name = "txtCvOkP1";
            this.txtCvOkP1.Size = new System.Drawing.Size(116, 26);
            this.txtCvOkP1.TabIndex = 2;
            this.txtCvOkP1.Text = "CV OK (<0.05)";
            // 
            // dgvP1
            // 
            this.dgvP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvP1.Location = new System.Drawing.Point(6, 36);
            this.dgvP1.Name = "dgvP1";
            this.dgvP1.RowHeadersWidth = 62;
            this.dgvP1.RowTemplate.Height = 28;
            this.dgvP1.Size = new System.Drawing.Size(810, 316);
            this.dgvP1.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Step";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Heigh (cm)";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Average";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "StdDev";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "CV";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // tabSingleKmeasurement
            // 
            this.tabSingleKmeasurement.Controls.Add(this.grbResults);
            this.tabSingleKmeasurement.Controls.Add(this.grbStep);
            this.tabSingleKmeasurement.Controls.Add(this.grbOverview);
            this.tabSingleKmeasurement.Location = new System.Drawing.Point(4, 29);
            this.tabSingleKmeasurement.Name = "tabSingleKmeasurement";
            this.tabSingleKmeasurement.Size = new System.Drawing.Size(2209, 790);
            this.tabSingleKmeasurement.TabIndex = 3;
            this.tabSingleKmeasurement.Text = "SingleKmeasurement";
            this.tabSingleKmeasurement.UseVisualStyleBackColor = true;
            // 
            // grbResults
            // 
            this.grbResults.BackColor = System.Drawing.Color.Transparent;
            this.grbResults.Controls.Add(this.txtTotalResults);
            this.grbResults.Controls.Add(this.txtLast300sResults);
            this.grbResults.Controls.Add(this.txtGlobalResults);
            this.grbResults.Controls.Add(this.lblStepHuberValue);
            this.grbResults.Controls.Add(this.txtLeafAreaStemConductivityLast300s);
            this.grbResults.Controls.Add(this.txtLeafAreaStemConductivityTotal);
            this.grbResults.Controls.Add(this.lblLeafAreaStemConductivity);
            this.grbResults.Controls.Add(this.lblStepStemConductivity);
            this.grbResults.Controls.Add(this.txtStepStemConductivityLast300s);
            this.grbResults.Controls.Add(this.txtStepHuberValueLast300s);
            this.grbResults.Controls.Add(this.txtStepConductivityLast300s);
            this.grbResults.Controls.Add(this.txtStepStemConductivityTotal);
            this.grbResults.Controls.Add(this.txtStepHuberValueTotal);
            this.grbResults.Controls.Add(this.txtStepConductivityTotal);
            this.grbResults.Controls.Add(this.lblConductivity);
            this.grbResults.Controls.Add(this.pictureBox4);
            this.grbResults.Location = new System.Drawing.Point(1344, 12);
            this.grbResults.Name = "grbResults";
            this.grbResults.Size = new System.Drawing.Size(816, 764);
            this.grbResults.TabIndex = 28;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Results";
            // 
            // txtTotalResults
            // 
            this.txtTotalResults.Location = new System.Drawing.Point(559, 28);
            this.txtTotalResults.Name = "txtTotalResults";
            this.txtTotalResults.Size = new System.Drawing.Size(118, 26);
            this.txtTotalResults.TabIndex = 146;
            this.txtTotalResults.Text = "Total";
            // 
            // txtLast300sResults
            // 
            this.txtLast300sResults.BackColor = System.Drawing.Color.LimeGreen;
            this.txtLast300sResults.Location = new System.Drawing.Point(683, 28);
            this.txtLast300sResults.Name = "txtLast300sResults";
            this.txtLast300sResults.Size = new System.Drawing.Size(118, 26);
            this.txtLast300sResults.TabIndex = 145;
            this.txtLast300sResults.Text = "Last 300 s";
            // 
            // txtGlobalResults
            // 
            this.txtGlobalResults.BackColor = System.Drawing.Color.LimeGreen;
            this.txtGlobalResults.Location = new System.Drawing.Point(292, 28);
            this.txtGlobalResults.Name = "txtGlobalResults";
            this.txtGlobalResults.Size = new System.Drawing.Size(261, 26);
            this.txtGlobalResults.TabIndex = 144;
            this.txtGlobalResults.Text = "Global Results";
            // 
            // lblStepHuberValue
            // 
            this.lblStepHuberValue.AutoSize = true;
            this.lblStepHuberValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStepHuberValue.Location = new System.Drawing.Point(357, 135);
            this.lblStepHuberValue.Name = "lblStepHuberValue";
            this.lblStepHuberValue.Size = new System.Drawing.Size(196, 20);
            this.lblStepHuberValue.TabIndex = 143;
            this.lblStepHuberValue.Text = "Huber value [HV] (m2 m-2)";
            // 
            // txtLeafAreaStemConductivityLast300s
            // 
            this.txtLeafAreaStemConductivityLast300s.Location = new System.Drawing.Point(683, 167);
            this.txtLeafAreaStemConductivityLast300s.Name = "txtLeafAreaStemConductivityLast300s";
            this.txtLeafAreaStemConductivityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtLeafAreaStemConductivityLast300s.TabIndex = 142;
            // 
            // txtLeafAreaStemConductivityTotal
            // 
            this.txtLeafAreaStemConductivityTotal.Location = new System.Drawing.Point(559, 167);
            this.txtLeafAreaStemConductivityTotal.Name = "txtLeafAreaStemConductivityTotal";
            this.txtLeafAreaStemConductivityTotal.Size = new System.Drawing.Size(118, 26);
            this.txtLeafAreaStemConductivityTotal.TabIndex = 140;
            // 
            // lblLeafAreaStemConductivity
            // 
            this.lblLeafAreaStemConductivity.AutoSize = true;
            this.lblLeafAreaStemConductivity.BackColor = System.Drawing.Color.Transparent;
            this.lblLeafAreaStemConductivity.Location = new System.Drawing.Point(127, 170);
            this.lblLeafAreaStemConductivity.Name = "lblLeafAreaStemConductivity";
            this.lblLeafAreaStemConductivity.Size = new System.Drawing.Size(428, 20);
            this.lblLeafAreaStemConductivity.TabIndex = 141;
            this.lblLeafAreaStemConductivity.Text = "leaf-area specific stem conductivity [kL] (mmol s-1 MPa m-1)";
            // 
            // lblStepStemConductivity
            // 
            this.lblStepStemConductivity.AutoSize = true;
            this.lblStepStemConductivity.BackColor = System.Drawing.Color.Transparent;
            this.lblStepStemConductivity.Location = new System.Drawing.Point(127, 103);
            this.lblStepStemConductivity.Name = "lblStepStemConductivity";
            this.lblStepStemConductivity.Size = new System.Drawing.Size(426, 20);
            this.lblStepStemConductivity.TabIndex = 139;
            this.lblStepStemConductivity.Text = "Stem area-specific stem conductivity [ks] (mol s-1 MPa m-1)";
            // 
            // txtStepStemConductivityLast300s
            // 
            this.txtStepStemConductivityLast300s.Location = new System.Drawing.Point(683, 100);
            this.txtStepStemConductivityLast300s.Name = "txtStepStemConductivityLast300s";
            this.txtStepStemConductivityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtStepStemConductivityLast300s.TabIndex = 138;
            // 
            // txtStepHuberValueLast300s
            // 
            this.txtStepHuberValueLast300s.Location = new System.Drawing.Point(683, 132);
            this.txtStepHuberValueLast300s.Name = "txtStepHuberValueLast300s";
            this.txtStepHuberValueLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtStepHuberValueLast300s.TabIndex = 137;
            // 
            // txtStepConductivityLast300s
            // 
            this.txtStepConductivityLast300s.Location = new System.Drawing.Point(683, 68);
            this.txtStepConductivityLast300s.Name = "txtStepConductivityLast300s";
            this.txtStepConductivityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtStepConductivityLast300s.TabIndex = 136;
            // 
            // txtStepStemConductivityTotal
            // 
            this.txtStepStemConductivityTotal.Location = new System.Drawing.Point(559, 100);
            this.txtStepStemConductivityTotal.Name = "txtStepStemConductivityTotal";
            this.txtStepStemConductivityTotal.Size = new System.Drawing.Size(118, 26);
            this.txtStepStemConductivityTotal.TabIndex = 135;
            // 
            // txtStepHuberValueTotal
            // 
            this.txtStepHuberValueTotal.Location = new System.Drawing.Point(559, 132);
            this.txtStepHuberValueTotal.Name = "txtStepHuberValueTotal";
            this.txtStepHuberValueTotal.Size = new System.Drawing.Size(118, 26);
            this.txtStepHuberValueTotal.TabIndex = 134;
            // 
            // txtStepConductivityTotal
            // 
            this.txtStepConductivityTotal.Location = new System.Drawing.Point(559, 68);
            this.txtStepConductivityTotal.Name = "txtStepConductivityTotal";
            this.txtStepConductivityTotal.Size = new System.Drawing.Size(118, 26);
            this.txtStepConductivityTotal.TabIndex = 132;
            // 
            // lblConductivity
            // 
            this.lblConductivity.AutoSize = true;
            this.lblConductivity.BackColor = System.Drawing.Color.Transparent;
            this.lblConductivity.Location = new System.Drawing.Point(329, 71);
            this.lblConductivity.Name = "lblConductivity";
            this.lblConductivity.Size = new System.Drawing.Size(224, 20);
            this.lblConductivity.TabIndex = 133;
            this.lblConductivity.Text = "Conductivity [k] (kg s-1 MPa m)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Interface.Properties.Resources.test2;
            this.pictureBox4.Location = new System.Drawing.Point(51, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(726, 486);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // grbStep
            // 
            this.grbStep.BackColor = System.Drawing.Color.Transparent;
            this.grbStep.Controls.Add(this.lblK25oCP3);
            this.grbStep.Controls.Add(this.txtK25oCP3Last300s);
            this.grbStep.Controls.Add(this.txtKCorrectedP3Last300s);
            this.grbStep.Controls.Add(this.txtK25oCP3Total);
            this.grbStep.Controls.Add(this.txtKCorrectedP3Total);
            this.grbStep.Controls.Add(this.lblKCorrectedP3);
            this.grbStep.Controls.Add(this.lblTempWaterBassin);
            this.grbStep.Controls.Add(this.txtTempWaterBassinLast300s);
            this.grbStep.Controls.Add(this.txtTempWaterBassinTotal);
            this.grbStep.Controls.Add(this.lblTempDownstream);
            this.grbStep.Controls.Add(this.lblResistancePeek);
            this.grbStep.Controls.Add(this.txtResistancePeekLast300s);
            this.grbStep.Controls.Add(this.txtAverageTempLast300s);
            this.grbStep.Controls.Add(this.txtResistancePeekTotal);
            this.grbStep.Controls.Add(this.txtAverageTempTotal);
            this.grbStep.Controls.Add(this.lblAverageTemp);
            this.grbStep.Controls.Add(this.lblTempUpstream);
            this.grbStep.Controls.Add(this.txtTempUpstreamLast300s);
            this.grbStep.Controls.Add(this.txtTempDownstreamLast300s);
            this.grbStep.Controls.Add(this.txtP3_P2StopcockLast300s);
            this.grbStep.Controls.Add(this.txtTempUpstreamTotal);
            this.grbStep.Controls.Add(this.txtTempDownstreamTotal);
            this.grbStep.Controls.Add(this.txtP3_P2StopcockTotal);
            this.grbStep.Controls.Add(this.lblP3_P2Stopcock);
            this.grbStep.Controls.Add(this.lblCvK);
            this.grbStep.Controls.Add(this.txtCvKLast300s);
            this.grbStep.Controls.Add(this.txtKrought_kgLast300s);
            this.grbStep.Controls.Add(this.txtCvKTotal);
            this.grbStep.Controls.Add(this.txtKrought_kgTotal);
            this.grbStep.Controls.Add(this.lblKrought_kg);
            this.grbStep.Controls.Add(this.lblP2bar);
            this.grbStep.Controls.Add(this.txtP2barLast300s);
            this.grbStep.Controls.Add(this.txtKrought_mmolLast300s);
            this.grbStep.Controls.Add(this.lblP1barLast300s);
            this.grbStep.Controls.Add(this.lblKrought_mmol);
            this.grbStep.Controls.Add(this.txtP2barTotal);
            this.grbStep.Controls.Add(this.txtKrought_mmolTotal);
            this.grbStep.Controls.Add(this.lblP1barTotal);
            this.grbStep.Controls.Add(this.lblP1bar);
            this.grbStep.Controls.Add(this.lblP2Validation);
            this.grbStep.Controls.Add(this.txtP2ValidationLast300s);
            this.grbStep.Controls.Add(this.txtAverageLast300s);
            this.grbStep.Controls.Add(this.txtP1ValidationLast300s);
            this.grbStep.Controls.Add(this.lblAverage);
            this.grbStep.Controls.Add(this.txtP2ValidationTotal);
            this.grbStep.Controls.Add(this.txtAverageTotal);
            this.grbStep.Controls.Add(this.txtP1ValidationTotal);
            this.grbStep.Controls.Add(this.txtTotalStep);
            this.grbStep.Controls.Add(this.txtLast300sStep);
            this.grbStep.Controls.Add(this.txtGlobalResultsStep);
            this.grbStep.Controls.Add(this.lblP1Validation);
            this.grbStep.Controls.Add(this.label40);
            this.grbStep.Controls.Add(this.lblStep3);
            this.grbStep.Controls.Add(this.lblStep1);
            this.grbStep.Location = new System.Drawing.Point(674, 12);
            this.grbStep.Name = "grbStep";
            this.grbStep.Size = new System.Drawing.Size(654, 764);
            this.grbStep.TabIndex = 3;
            this.grbStep.TabStop = false;
            this.grbStep.Text = "Step";
            // 
            // lblK25oCP3
            // 
            this.lblK25oCP3.AutoSize = true;
            this.lblK25oCP3.Location = new System.Drawing.Point(186, 672);
            this.lblK25oCP3.Name = "lblK25oCP3";
            this.lblK25oCP3.Size = new System.Drawing.Size(199, 20);
            this.lblK25oCP3.TabIndex = 140;
            this.lblK25oCP3.Text = "K at 25 oC corrected for p3";
            // 
            // txtK25oCP3Last300s
            // 
            this.txtK25oCP3Last300s.Location = new System.Drawing.Point(518, 666);
            this.txtK25oCP3Last300s.Name = "txtK25oCP3Last300s";
            this.txtK25oCP3Last300s.Size = new System.Drawing.Size(118, 26);
            this.txtK25oCP3Last300s.TabIndex = 139;
            // 
            // txtKCorrectedP3Last300s
            // 
            this.txtKCorrectedP3Last300s.Location = new System.Drawing.Point(518, 634);
            this.txtKCorrectedP3Last300s.Name = "txtKCorrectedP3Last300s";
            this.txtKCorrectedP3Last300s.Size = new System.Drawing.Size(118, 26);
            this.txtKCorrectedP3Last300s.TabIndex = 138;
            // 
            // txtK25oCP3Total
            // 
            this.txtK25oCP3Total.Location = new System.Drawing.Point(394, 666);
            this.txtK25oCP3Total.Name = "txtK25oCP3Total";
            this.txtK25oCP3Total.Size = new System.Drawing.Size(118, 26);
            this.txtK25oCP3Total.TabIndex = 137;
            // 
            // txtKCorrectedP3Total
            // 
            this.txtKCorrectedP3Total.Location = new System.Drawing.Point(394, 634);
            this.txtKCorrectedP3Total.Name = "txtKCorrectedP3Total";
            this.txtKCorrectedP3Total.Size = new System.Drawing.Size(118, 26);
            this.txtKCorrectedP3Total.TabIndex = 135;
            // 
            // lblKCorrectedP3
            // 
            this.lblKCorrectedP3.AutoSize = true;
            this.lblKCorrectedP3.Location = new System.Drawing.Point(11, 637);
            this.lblKCorrectedP3.Name = "lblKCorrectedP3";
            this.lblKCorrectedP3.Size = new System.Drawing.Size(377, 20);
            this.lblKCorrectedP3.TabIndex = 136;
            this.lblKCorrectedP3.Text = "K at measurement temperature and corrected for p3";
            // 
            // lblTempWaterBassin
            // 
            this.lblTempWaterBassin.AutoSize = true;
            this.lblTempWaterBassin.Location = new System.Drawing.Point(26, 575);
            this.lblTempWaterBassin.Name = "lblTempWaterBassin";
            this.lblTempWaterBassin.Size = new System.Drawing.Size(362, 20);
            this.lblTempWaterBassin.TabIndex = 134;
            this.lblTempWaterBassin.Text = "T3 : Temperature of water bassin with sample (oC)";
            // 
            // txtTempWaterBassinLast300s
            // 
            this.txtTempWaterBassinLast300s.Location = new System.Drawing.Point(518, 572);
            this.txtTempWaterBassinLast300s.Name = "txtTempWaterBassinLast300s";
            this.txtTempWaterBassinLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtTempWaterBassinLast300s.TabIndex = 133;
            // 
            // txtTempWaterBassinTotal
            // 
            this.txtTempWaterBassinTotal.Location = new System.Drawing.Point(394, 572);
            this.txtTempWaterBassinTotal.Name = "txtTempWaterBassinTotal";
            this.txtTempWaterBassinTotal.Size = new System.Drawing.Size(118, 26);
            this.txtTempWaterBassinTotal.TabIndex = 132;
            // 
            // lblTempDownstream
            // 
            this.lblTempDownstream.AutoSize = true;
            this.lblTempDownstream.Location = new System.Drawing.Point(32, 449);
            this.lblTempDownstream.Name = "lblTempDownstream";
            this.lblTempDownstream.Size = new System.Drawing.Size(356, 20);
            this.lblTempDownstream.TabIndex = 131;
            this.lblTempDownstream.Text = "T2: Temperature downstream of peek tubing (oC)";
            // 
            // lblResistancePeek
            // 
            this.lblResistancePeek.AutoSize = true;
            this.lblResistancePeek.Location = new System.Drawing.Point(83, 520);
            this.lblResistancePeek.Name = "lblResistancePeek";
            this.lblResistancePeek.Size = new System.Drawing.Size(299, 20);
            this.lblResistancePeek.TabIndex = 130;
            this.lblResistancePeek.Text = "resistance of PEEK tubing at actual temp";
            // 
            // txtResistancePeekLast300s
            // 
            this.txtResistancePeekLast300s.Location = new System.Drawing.Point(518, 516);
            this.txtResistancePeekLast300s.Name = "txtResistancePeekLast300s";
            this.txtResistancePeekLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtResistancePeekLast300s.TabIndex = 129;
            // 
            // txtAverageTempLast300s
            // 
            this.txtAverageTempLast300s.Location = new System.Drawing.Point(518, 484);
            this.txtAverageTempLast300s.Name = "txtAverageTempLast300s";
            this.txtAverageTempLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtAverageTempLast300s.TabIndex = 128;
            // 
            // txtResistancePeekTotal
            // 
            this.txtResistancePeekTotal.Location = new System.Drawing.Point(394, 516);
            this.txtResistancePeekTotal.Name = "txtResistancePeekTotal";
            this.txtResistancePeekTotal.Size = new System.Drawing.Size(118, 26);
            this.txtResistancePeekTotal.TabIndex = 127;
            // 
            // txtAverageTempTotal
            // 
            this.txtAverageTempTotal.Location = new System.Drawing.Point(394, 484);
            this.txtAverageTempTotal.Name = "txtAverageTempTotal";
            this.txtAverageTempTotal.Size = new System.Drawing.Size(118, 26);
            this.txtAverageTempTotal.TabIndex = 125;
            // 
            // lblAverageTemp
            // 
            this.lblAverageTemp.AutoSize = true;
            this.lblAverageTemp.Location = new System.Drawing.Point(42, 488);
            this.lblAverageTemp.Name = "lblAverageTemp";
            this.lblAverageTemp.Size = new System.Drawing.Size(346, 20);
            this.lblAverageTemp.TabIndex = 126;
            this.lblAverageTemp.Text = "Average temperature through PEEK tubing (oC)";
            // 
            // lblTempUpstream
            // 
            this.lblTempUpstream.AutoSize = true;
            this.lblTempUpstream.Location = new System.Drawing.Point(52, 417);
            this.lblTempUpstream.Name = "lblTempUpstream";
            this.lblTempUpstream.Size = new System.Drawing.Size(336, 20);
            this.lblTempUpstream.TabIndex = 124;
            this.lblTempUpstream.Text = "T1: Temperature upstream of peek tubing (oC)";
            // 
            // txtTempUpstreamLast300s
            // 
            this.txtTempUpstreamLast300s.Location = new System.Drawing.Point(518, 414);
            this.txtTempUpstreamLast300s.Name = "txtTempUpstreamLast300s";
            this.txtTempUpstreamLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtTempUpstreamLast300s.TabIndex = 123;
            // 
            // txtTempDownstreamLast300s
            // 
            this.txtTempDownstreamLast300s.Location = new System.Drawing.Point(518, 446);
            this.txtTempDownstreamLast300s.Name = "txtTempDownstreamLast300s";
            this.txtTempDownstreamLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtTempDownstreamLast300s.TabIndex = 122;
            // 
            // txtP3_P2StopcockLast300s
            // 
            this.txtP3_P2StopcockLast300s.Location = new System.Drawing.Point(518, 382);
            this.txtP3_P2StopcockLast300s.Name = "txtP3_P2StopcockLast300s";
            this.txtP3_P2StopcockLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtP3_P2StopcockLast300s.TabIndex = 121;
            // 
            // txtTempUpstreamTotal
            // 
            this.txtTempUpstreamTotal.Location = new System.Drawing.Point(394, 414);
            this.txtTempUpstreamTotal.Name = "txtTempUpstreamTotal";
            this.txtTempUpstreamTotal.Size = new System.Drawing.Size(118, 26);
            this.txtTempUpstreamTotal.TabIndex = 119;
            // 
            // txtTempDownstreamTotal
            // 
            this.txtTempDownstreamTotal.Location = new System.Drawing.Point(394, 446);
            this.txtTempDownstreamTotal.Name = "txtTempDownstreamTotal";
            this.txtTempDownstreamTotal.Size = new System.Drawing.Size(118, 26);
            this.txtTempDownstreamTotal.TabIndex = 118;
            // 
            // txtP3_P2StopcockTotal
            // 
            this.txtP3_P2StopcockTotal.Location = new System.Drawing.Point(394, 382);
            this.txtP3_P2StopcockTotal.Name = "txtP3_P2StopcockTotal";
            this.txtP3_P2StopcockTotal.Size = new System.Drawing.Size(118, 26);
            this.txtP3_P2StopcockTotal.TabIndex = 116;
            // 
            // lblP3_P2Stopcock
            // 
            this.lblP3_P2Stopcock.AutoSize = true;
            this.lblP3_P2Stopcock.Location = new System.Drawing.Point(154, 385);
            this.lblP3_P2Stopcock.Name = "lblP3_P2Stopcock";
            this.lblP3_P2Stopcock.Size = new System.Drawing.Size(234, 20);
            this.lblP3_P2Stopcock.TabIndex = 117;
            this.lblP3_P2Stopcock.Text = "P3 (P2 with stopcock 4 off) (bar)";
            // 
            // lblCvK
            // 
            this.lblCvK.AutoSize = true;
            this.lblCvK.Location = new System.Drawing.Point(294, 324);
            this.lblCvK.Name = "lblCvK";
            this.lblCvK.Size = new System.Drawing.Size(91, 20);
            this.lblCvK.TabIndex = 115;
            this.lblCvK.Text = "CV of K (%)";
            // 
            // txtCvKLast300s
            // 
            this.txtCvKLast300s.Location = new System.Drawing.Point(518, 321);
            this.txtCvKLast300s.Name = "txtCvKLast300s";
            this.txtCvKLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtCvKLast300s.TabIndex = 114;
            // 
            // txtKrought_kgLast300s
            // 
            this.txtKrought_kgLast300s.Location = new System.Drawing.Point(518, 289);
            this.txtKrought_kgLast300s.Name = "txtKrought_kgLast300s";
            this.txtKrought_kgLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtKrought_kgLast300s.TabIndex = 112;
            // 
            // txtCvKTotal
            // 
            this.txtCvKTotal.Location = new System.Drawing.Point(394, 321);
            this.txtCvKTotal.Name = "txtCvKTotal";
            this.txtCvKTotal.Size = new System.Drawing.Size(118, 26);
            this.txtCvKTotal.TabIndex = 110;
            // 
            // txtKrought_kgTotal
            // 
            this.txtKrought_kgTotal.Location = new System.Drawing.Point(394, 289);
            this.txtKrought_kgTotal.Name = "txtKrought_kgTotal";
            this.txtKrought_kgTotal.Size = new System.Drawing.Size(118, 26);
            this.txtKrought_kgTotal.TabIndex = 107;
            // 
            // lblKrought_kg
            // 
            this.lblKrought_kg.AutoSize = true;
            this.lblKrought_kg.Location = new System.Drawing.Point(199, 292);
            this.lblKrought_kg.Name = "lblKrought_kg";
            this.lblKrought_kg.Size = new System.Drawing.Size(183, 20);
            this.lblKrought_kg.TabIndex = 108;
            this.lblKrought_kg.Text = "K \"rough\" (kg s-1 MPa-1)";
            // 
            // lblP2bar
            // 
            this.lblP2bar.AutoSize = true;
            this.lblP2bar.Location = new System.Drawing.Point(317, 222);
            this.lblP2bar.Name = "lblP2bar";
            this.lblP2bar.Size = new System.Drawing.Size(65, 20);
            this.lblP2bar.TabIndex = 105;
            this.lblP2bar.Text = "P2 (bar)";
            // 
            // txtP2barLast300s
            // 
            this.txtP2barLast300s.Location = new System.Drawing.Point(518, 219);
            this.txtP2barLast300s.Name = "txtP2barLast300s";
            this.txtP2barLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtP2barLast300s.TabIndex = 104;
            // 
            // txtKrought_mmolLast300s
            // 
            this.txtKrought_mmolLast300s.Location = new System.Drawing.Point(518, 251);
            this.txtKrought_mmolLast300s.Name = "txtKrought_mmolLast300s";
            this.txtKrought_mmolLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtKrought_mmolLast300s.TabIndex = 103;
            // 
            // lblP1barLast300s
            // 
            this.lblP1barLast300s.Location = new System.Drawing.Point(518, 187);
            this.lblP1barLast300s.Name = "lblP1barLast300s";
            this.lblP1barLast300s.Size = new System.Drawing.Size(118, 26);
            this.lblP1barLast300s.TabIndex = 102;
            // 
            // lblKrought_mmol
            // 
            this.lblKrought_mmol.AutoSize = true;
            this.lblKrought_mmol.Location = new System.Drawing.Point(178, 254);
            this.lblKrought_mmol.Name = "lblKrought_mmol";
            this.lblKrought_mmol.Size = new System.Drawing.Size(204, 20);
            this.lblKrought_mmol.TabIndex = 101;
            this.lblKrought_mmol.Text = "K \"rough\" (mmol s-1 MPa-1)";
            // 
            // txtP2barTotal
            // 
            this.txtP2barTotal.Location = new System.Drawing.Point(394, 219);
            this.txtP2barTotal.Name = "txtP2barTotal";
            this.txtP2barTotal.Size = new System.Drawing.Size(118, 26);
            this.txtP2barTotal.TabIndex = 100;
            // 
            // txtKrought_mmolTotal
            // 
            this.txtKrought_mmolTotal.Location = new System.Drawing.Point(394, 251);
            this.txtKrought_mmolTotal.Name = "txtKrought_mmolTotal";
            this.txtKrought_mmolTotal.Size = new System.Drawing.Size(118, 26);
            this.txtKrought_mmolTotal.TabIndex = 99;
            // 
            // lblP1barTotal
            // 
            this.lblP1barTotal.Location = new System.Drawing.Point(394, 187);
            this.lblP1barTotal.Name = "lblP1barTotal";
            this.lblP1barTotal.Size = new System.Drawing.Size(118, 26);
            this.lblP1barTotal.TabIndex = 97;
            // 
            // lblP1bar
            // 
            this.lblP1bar.AutoSize = true;
            this.lblP1bar.Location = new System.Drawing.Point(317, 190);
            this.lblP1bar.Name = "lblP1bar";
            this.lblP1bar.Size = new System.Drawing.Size(65, 20);
            this.lblP1bar.TabIndex = 98;
            this.lblP1bar.Text = "P1 (bar)";
            // 
            // lblP2Validation
            // 
            this.lblP2Validation.AutoSize = true;
            this.lblP2Validation.Location = new System.Drawing.Point(134, 97);
            this.lblP2Validation.Name = "lblP2Validation";
            this.lblP2Validation.Size = new System.Drawing.Size(254, 20);
            this.lblP2Validation.TabIndex = 96;
            this.lblP2Validation.Text = "Pressure sensor validation P2 (bar)";
            // 
            // txtP2ValidationLast300s
            // 
            this.txtP2ValidationLast300s.Location = new System.Drawing.Point(518, 97);
            this.txtP2ValidationLast300s.Name = "txtP2ValidationLast300s";
            this.txtP2ValidationLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtP2ValidationLast300s.TabIndex = 85;
            // 
            // txtAverageLast300s
            // 
            this.txtAverageLast300s.Location = new System.Drawing.Point(518, 129);
            this.txtAverageLast300s.Name = "txtAverageLast300s";
            this.txtAverageLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtAverageLast300s.TabIndex = 84;
            // 
            // txtP1ValidationLast300s
            // 
            this.txtP1ValidationLast300s.Location = new System.Drawing.Point(518, 65);
            this.txtP1ValidationLast300s.Name = "txtP1ValidationLast300s";
            this.txtP1ValidationLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtP1ValidationLast300s.TabIndex = 82;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(317, 132);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(68, 20);
            this.lblAverage.TabIndex = 80;
            this.lblAverage.Text = "Average";
            // 
            // txtP2ValidationTotal
            // 
            this.txtP2ValidationTotal.Location = new System.Drawing.Point(394, 97);
            this.txtP2ValidationTotal.Name = "txtP2ValidationTotal";
            this.txtP2ValidationTotal.Size = new System.Drawing.Size(118, 26);
            this.txtP2ValidationTotal.TabIndex = 79;
            // 
            // txtAverageTotal
            // 
            this.txtAverageTotal.Location = new System.Drawing.Point(394, 129);
            this.txtAverageTotal.Name = "txtAverageTotal";
            this.txtAverageTotal.Size = new System.Drawing.Size(118, 26);
            this.txtAverageTotal.TabIndex = 78;
            // 
            // txtP1ValidationTotal
            // 
            this.txtP1ValidationTotal.Location = new System.Drawing.Point(394, 65);
            this.txtP1ValidationTotal.Name = "txtP1ValidationTotal";
            this.txtP1ValidationTotal.Size = new System.Drawing.Size(118, 26);
            this.txtP1ValidationTotal.TabIndex = 71;
            // 
            // txtTotalStep
            // 
            this.txtTotalStep.Location = new System.Drawing.Point(394, 31);
            this.txtTotalStep.Name = "txtTotalStep";
            this.txtTotalStep.Size = new System.Drawing.Size(118, 26);
            this.txtTotalStep.TabIndex = 76;
            this.txtTotalStep.Text = "Total";
            // 
            // txtLast300sStep
            // 
            this.txtLast300sStep.BackColor = System.Drawing.Color.LimeGreen;
            this.txtLast300sStep.Location = new System.Drawing.Point(518, 31);
            this.txtLast300sStep.Name = "txtLast300sStep";
            this.txtLast300sStep.Size = new System.Drawing.Size(118, 26);
            this.txtLast300sStep.TabIndex = 75;
            this.txtLast300sStep.Text = "Last 300 s";
            // 
            // txtGlobalResultsStep
            // 
            this.txtGlobalResultsStep.BackColor = System.Drawing.Color.LimeGreen;
            this.txtGlobalResultsStep.Location = new System.Drawing.Point(127, 31);
            this.txtGlobalResultsStep.Name = "txtGlobalResultsStep";
            this.txtGlobalResultsStep.Size = new System.Drawing.Size(261, 26);
            this.txtGlobalResultsStep.TabIndex = 70;
            this.txtGlobalResultsStep.Text = "Global Results";
            // 
            // lblP1Validation
            // 
            this.lblP1Validation.AutoSize = true;
            this.lblP1Validation.Location = new System.Drawing.Point(134, 68);
            this.lblP1Validation.Name = "lblP1Validation";
            this.lblP1Validation.Size = new System.Drawing.Size(254, 20);
            this.lblP1Validation.TabIndex = 74;
            this.lblP1Validation.Text = "Pressure sensor validation P1 (bar)";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Lime;
            this.label40.Location = new System.Drawing.Point(17, 190);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 20);
            this.label40.TabIndex = 68;
            this.label40.Text = "Step 2 >>";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.BackColor = System.Drawing.Color.Lime;
            this.lblStep3.Location = new System.Drawing.Point(17, 388);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(78, 20);
            this.lblStep3.TabIndex = 67;
            this.lblStep3.Text = "Step 3 >>";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.BackColor = System.Drawing.Color.Lime;
            this.lblStep1.Location = new System.Drawing.Point(17, 31);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(78, 20);
            this.lblStep1.TabIndex = 66;
            this.lblStep1.Text = "Step 1 >>";
            // 
            // grbOverview
            // 
            this.grbOverview.BackColor = System.Drawing.Color.Transparent;
            this.grbOverview.Controls.Add(this.btnStartMesure);
            this.grbOverview.Controls.Add(this.btnReset);
            this.grbOverview.Controls.Add(this.lblSeconde);
            this.grbOverview.Controls.Add(this.lblTimer);
            this.grbOverview.Controls.Add(this.grbCalibrationOverview);
            this.grbOverview.Controls.Add(this.lblStability);
            this.grbOverview.Controls.Add(this.lblTime);
            this.grbOverview.Controls.Add(this.lblPresureValidation);
            this.grbOverview.Controls.Add(this.lblOptimalPeekTube);
            this.grbOverview.Controls.Add(this.txtPresureValidationTotal);
            this.grbOverview.Controls.Add(this.txtOptimalPeekTubeLast300s);
            this.grbOverview.Controls.Add(this.txtTimeValidation);
            this.grbOverview.Controls.Add(this.txtPresureValidationLast300s);
            this.grbOverview.Controls.Add(this.txtStabilityLast300s);
            this.grbOverview.Controls.Add(this.txtOptimalPeekTubeTotal);
            this.grbOverview.Controls.Add(this.txtStemConductivityLast300s);
            this.grbOverview.Controls.Add(this.txtHuberValueLast300s);
            this.grbOverview.Controls.Add(this.txtConductivityLast300s);
            this.grbOverview.Controls.Add(this.txtLeafAreaLast300s);
            this.grbOverview.Controls.Add(this.lblLeafArea);
            this.grbOverview.Controls.Add(this.lblHuberValue);
            this.grbOverview.Controls.Add(this.txtStemConductivityTotal);
            this.grbOverview.Controls.Add(this.txtHuberValueTotal);
            this.grbOverview.Controls.Add(this.txtConductivityTotal);
            this.grbOverview.Controls.Add(this.txtLeafAreaTotal);
            this.grbOverview.Controls.Add(this.txtTotalOverview);
            this.grbOverview.Controls.Add(this.txtLast300sOverview);
            this.grbOverview.Controls.Add(this.txtGlobalResultsOverview);
            this.grbOverview.Controls.Add(this.lblCondutivityTotal);
            this.grbOverview.Controls.Add(this.lblStemConductivity);
            this.grbOverview.Controls.Add(this.lblValidation);
            this.grbOverview.Controls.Add(this.lblResults);
            this.grbOverview.Location = new System.Drawing.Point(16, 12);
            this.grbOverview.Name = "grbOverview";
            this.grbOverview.Size = new System.Drawing.Size(647, 764);
            this.grbOverview.TabIndex = 2;
            this.grbOverview.TabStop = false;
            this.grbOverview.Text = "Overview";
            // 
            // btnStartMesure
            // 
            this.btnStartMesure.Location = new System.Drawing.Point(399, 703);
            this.btnStartMesure.Name = "btnStartMesure";
            this.btnStartMesure.Size = new System.Drawing.Size(131, 43);
            this.btnStartMesure.TabIndex = 68;
            this.btnStartMesure.Text = "Start Mesure";
            this.btnStartMesure.UseVisualStyleBackColor = true;
            this.btnStartMesure.Click += new System.EventHandler(this.btnStartMesure_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(536, 703);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 43);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSeconde
            // 
            this.lblSeconde.AutoSize = true;
            this.lblSeconde.Location = new System.Drawing.Point(457, 650);
            this.lblSeconde.Name = "lblSeconde";
            this.lblSeconde.Size = new System.Drawing.Size(27, 20);
            this.lblSeconde.TabIndex = 66;
            this.lblSeconde.Text = "00";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(395, 650);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(56, 20);
            this.lblTimer.TabIndex = 31;
            this.lblTimer.Text = "Timer :";
            // 
            // grbCalibrationOverview
            // 
            this.grbCalibrationOverview.Controls.Add(this.lblP2Calibration);
            this.grbCalibrationOverview.Controls.Add(this.lblP1Calibration);
            this.grbCalibrationOverview.Controls.Add(this.txtInterceptOverviewP2);
            this.grbCalibrationOverview.Controls.Add(this.txtSlopeOverviewP2);
            this.grbCalibrationOverview.Controls.Add(this.lblInterceptOverviewP2);
            this.grbCalibrationOverview.Controls.Add(this.lblSlopeOverviewP2);
            this.grbCalibrationOverview.Controls.Add(this.txtInterceptOverviewP1);
            this.grbCalibrationOverview.Controls.Add(this.txtSlopeOverviewP1);
            this.grbCalibrationOverview.Controls.Add(this.lblInterceptOverviewP1);
            this.grbCalibrationOverview.Controls.Add(this.lblSlopeOverviewP1);
            this.grbCalibrationOverview.Location = new System.Drawing.Point(239, 345);
            this.grbCalibrationOverview.Name = "grbCalibrationOverview";
            this.grbCalibrationOverview.Size = new System.Drawing.Size(402, 195);
            this.grbCalibrationOverview.TabIndex = 30;
            this.grbCalibrationOverview.TabStop = false;
            this.grbCalibrationOverview.Text = "Calibration";
            // 
            // lblP2Calibration
            // 
            this.lblP2Calibration.AutoSize = true;
            this.lblP2Calibration.BackColor = System.Drawing.Color.LightGray;
            this.lblP2Calibration.Location = new System.Drawing.Point(16, 111);
            this.lblP2Calibration.Name = "lblP2Calibration";
            this.lblP2Calibration.Size = new System.Drawing.Size(129, 20);
            this.lblP2Calibration.TabIndex = 20;
            this.lblP2Calibration.Text = "P2 Calibration >>";
            // 
            // lblP1Calibration
            // 
            this.lblP1Calibration.AutoSize = true;
            this.lblP1Calibration.BackColor = System.Drawing.Color.LightGray;
            this.lblP1Calibration.Location = new System.Drawing.Point(13, 31);
            this.lblP1Calibration.Name = "lblP1Calibration";
            this.lblP1Calibration.Size = new System.Drawing.Size(129, 20);
            this.lblP1Calibration.TabIndex = 19;
            this.lblP1Calibration.Text = "P1 Calibration >>";
            // 
            // txtInterceptOverviewP2
            // 
            this.txtInterceptOverviewP2.Location = new System.Drawing.Point(275, 143);
            this.txtInterceptOverviewP2.Name = "txtInterceptOverviewP2";
            this.txtInterceptOverviewP2.Size = new System.Drawing.Size(116, 26);
            this.txtInterceptOverviewP2.TabIndex = 18;
            this.txtInterceptOverviewP2.Text = "4.68024E-05";
            // 
            // txtSlopeOverviewP2
            // 
            this.txtSlopeOverviewP2.Location = new System.Drawing.Point(275, 108);
            this.txtSlopeOverviewP2.Name = "txtSlopeOverviewP2";
            this.txtSlopeOverviewP2.Size = new System.Drawing.Size(116, 26);
            this.txtSlopeOverviewP2.TabIndex = 15;
            this.txtSlopeOverviewP2.Text = "6.24097R-06";
            // 
            // lblInterceptOverviewP2
            // 
            this.lblInterceptOverviewP2.AutoSize = true;
            this.lblInterceptOverviewP2.Location = new System.Drawing.Point(184, 149);
            this.lblInterceptOverviewP2.Name = "lblInterceptOverviewP2";
            this.lblInterceptOverviewP2.Size = new System.Drawing.Size(85, 20);
            this.lblInterceptOverviewP2.TabIndex = 17;
            this.lblInterceptOverviewP2.Text = "Intercept : ";
            // 
            // lblSlopeOverviewP2
            // 
            this.lblSlopeOverviewP2.AutoSize = true;
            this.lblSlopeOverviewP2.Location = new System.Drawing.Point(207, 111);
            this.lblSlopeOverviewP2.Name = "lblSlopeOverviewP2";
            this.lblSlopeOverviewP2.Size = new System.Drawing.Size(62, 20);
            this.lblSlopeOverviewP2.TabIndex = 16;
            this.lblSlopeOverviewP2.Text = "Slope : ";
            // 
            // txtInterceptOverviewP1
            // 
            this.txtInterceptOverviewP1.Location = new System.Drawing.Point(275, 60);
            this.txtInterceptOverviewP1.Name = "txtInterceptOverviewP1";
            this.txtInterceptOverviewP1.Size = new System.Drawing.Size(116, 26);
            this.txtInterceptOverviewP1.TabIndex = 14;
            this.txtInterceptOverviewP1.Text = "4.68024E-05";
            // 
            // txtSlopeOverviewP1
            // 
            this.txtSlopeOverviewP1.Location = new System.Drawing.Point(275, 25);
            this.txtSlopeOverviewP1.Name = "txtSlopeOverviewP1";
            this.txtSlopeOverviewP1.Size = new System.Drawing.Size(116, 26);
            this.txtSlopeOverviewP1.TabIndex = 11;
            this.txtSlopeOverviewP1.Text = "6.24097R-06";
            // 
            // lblInterceptOverviewP1
            // 
            this.lblInterceptOverviewP1.AutoSize = true;
            this.lblInterceptOverviewP1.Location = new System.Drawing.Point(184, 66);
            this.lblInterceptOverviewP1.Name = "lblInterceptOverviewP1";
            this.lblInterceptOverviewP1.Size = new System.Drawing.Size(85, 20);
            this.lblInterceptOverviewP1.TabIndex = 13;
            this.lblInterceptOverviewP1.Text = "Intercept : ";
            // 
            // lblSlopeOverviewP1
            // 
            this.lblSlopeOverviewP1.AutoSize = true;
            this.lblSlopeOverviewP1.Location = new System.Drawing.Point(207, 28);
            this.lblSlopeOverviewP1.Name = "lblSlopeOverviewP1";
            this.lblSlopeOverviewP1.Size = new System.Drawing.Size(62, 20);
            this.lblSlopeOverviewP1.TabIndex = 12;
            this.lblSlopeOverviewP1.Text = "Slope : ";
            // 
            // lblStability
            // 
            this.lblStability.AutoSize = true;
            this.lblStability.Location = new System.Drawing.Point(242, 289);
            this.lblStability.Name = "lblStability";
            this.lblStability.Size = new System.Drawing.Size(148, 20);
            this.lblStability.TabIndex = 65;
            this.lblStability.Text = "Stability (CV < 0.05)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(248, 257);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 20);
            this.lblTime.TabIndex = 64;
            this.lblTime.Text = "Time (min 300 sec)";
            // 
            // lblPresureValidation
            // 
            this.lblPresureValidation.AutoSize = true;
            this.lblPresureValidation.Location = new System.Drawing.Point(196, 225);
            this.lblPresureValidation.Name = "lblPresureValidation";
            this.lblPresureValidation.Size = new System.Drawing.Size(194, 20);
            this.lblPresureValidation.TabIndex = 63;
            this.lblPresureValidation.Text = "Presure sensors validation";
            // 
            // lblOptimalPeekTube
            // 
            this.lblOptimalPeekTube.AutoSize = true;
            this.lblOptimalPeekTube.Location = new System.Drawing.Point(158, 193);
            this.lblOptimalPeekTube.Name = "lblOptimalPeekTube";
            this.lblOptimalPeekTube.Size = new System.Drawing.Size(232, 20);
            this.lblOptimalPeekTube.TabIndex = 62;
            this.lblOptimalPeekTube.Text = "Validation for optimal peek tube";
            // 
            // txtPresureValidationTotal
            // 
            this.txtPresureValidationTotal.BackColor = System.Drawing.Color.LimeGreen;
            this.txtPresureValidationTotal.Location = new System.Drawing.Point(399, 222);
            this.txtPresureValidationTotal.Name = "txtPresureValidationTotal";
            this.txtPresureValidationTotal.Size = new System.Drawing.Size(118, 26);
            this.txtPresureValidationTotal.TabIndex = 61;
            this.txtPresureValidationTotal.Text = "OK";
            this.txtPresureValidationTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOptimalPeekTubeLast300s
            // 
            this.txtOptimalPeekTubeLast300s.BackColor = System.Drawing.Color.LimeGreen;
            this.txtOptimalPeekTubeLast300s.Location = new System.Drawing.Point(523, 190);
            this.txtOptimalPeekTubeLast300s.Name = "txtOptimalPeekTubeLast300s";
            this.txtOptimalPeekTubeLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtOptimalPeekTubeLast300s.TabIndex = 60;
            this.txtOptimalPeekTubeLast300s.Text = "OK";
            this.txtOptimalPeekTubeLast300s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeValidation
            // 
            this.txtTimeValidation.BackColor = System.Drawing.Color.LimeGreen;
            this.txtTimeValidation.Location = new System.Drawing.Point(523, 254);
            this.txtTimeValidation.Name = "txtTimeValidation";
            this.txtTimeValidation.Size = new System.Drawing.Size(118, 26);
            this.txtTimeValidation.TabIndex = 59;
            this.txtTimeValidation.Text = "OK";
            this.txtTimeValidation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPresureValidationLast300s
            // 
            this.txtPresureValidationLast300s.BackColor = System.Drawing.Color.LightGray;
            this.txtPresureValidationLast300s.Location = new System.Drawing.Point(523, 222);
            this.txtPresureValidationLast300s.Name = "txtPresureValidationLast300s";
            this.txtPresureValidationLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtPresureValidationLast300s.TabIndex = 57;
            this.txtPresureValidationLast300s.Text = "OK";
            this.txtPresureValidationLast300s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStabilityLast300s
            // 
            this.txtStabilityLast300s.BackColor = System.Drawing.Color.Red;
            this.txtStabilityLast300s.Location = new System.Drawing.Point(523, 286);
            this.txtStabilityLast300s.Name = "txtStabilityLast300s";
            this.txtStabilityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtStabilityLast300s.TabIndex = 55;
            this.txtStabilityLast300s.Text = "WAIT";
            this.txtStabilityLast300s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOptimalPeekTubeTotal
            // 
            this.txtOptimalPeekTubeTotal.BackColor = System.Drawing.Color.LimeGreen;
            this.txtOptimalPeekTubeTotal.Location = new System.Drawing.Point(399, 190);
            this.txtOptimalPeekTubeTotal.Name = "txtOptimalPeekTubeTotal";
            this.txtOptimalPeekTubeTotal.Size = new System.Drawing.Size(118, 26);
            this.txtOptimalPeekTubeTotal.TabIndex = 50;
            this.txtOptimalPeekTubeTotal.Text = "OK";
            this.txtOptimalPeekTubeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStemConductivityLast300s
            // 
            this.txtStemConductivityLast300s.Location = new System.Drawing.Point(523, 91);
            this.txtStemConductivityLast300s.Name = "txtStemConductivityLast300s";
            this.txtStemConductivityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtStemConductivityLast300s.TabIndex = 49;
            // 
            // txtHuberValueLast300s
            // 
            this.txtHuberValueLast300s.Location = new System.Drawing.Point(523, 123);
            this.txtHuberValueLast300s.Name = "txtHuberValueLast300s";
            this.txtHuberValueLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtHuberValueLast300s.TabIndex = 48;
            // 
            // txtConductivityLast300s
            // 
            this.txtConductivityLast300s.Location = new System.Drawing.Point(523, 59);
            this.txtConductivityLast300s.Name = "txtConductivityLast300s";
            this.txtConductivityLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtConductivityLast300s.TabIndex = 46;
            // 
            // txtLeafAreaLast300s
            // 
            this.txtLeafAreaLast300s.Location = new System.Drawing.Point(523, 155);
            this.txtLeafAreaLast300s.Name = "txtLeafAreaLast300s";
            this.txtLeafAreaLast300s.Size = new System.Drawing.Size(118, 26);
            this.txtLeafAreaLast300s.TabIndex = 47;
            // 
            // lblLeafArea
            // 
            this.lblLeafArea.AutoSize = true;
            this.lblLeafArea.Location = new System.Drawing.Point(144, 158);
            this.lblLeafArea.Name = "lblLeafArea";
            this.lblLeafArea.Size = new System.Drawing.Size(246, 20);
            this.lblLeafArea.TabIndex = 45;
            this.lblLeafArea.Text = "leaf-area specific stem condutivity";
            // 
            // lblHuberValue
            // 
            this.lblHuberValue.AutoSize = true;
            this.lblHuberValue.Location = new System.Drawing.Point(299, 129);
            this.lblHuberValue.Name = "lblHuberValue";
            this.lblHuberValue.Size = new System.Drawing.Size(94, 20);
            this.lblHuberValue.TabIndex = 44;
            this.lblHuberValue.Text = "Huber value";
            // 
            // txtStemConductivityTotal
            // 
            this.txtStemConductivityTotal.Location = new System.Drawing.Point(399, 91);
            this.txtStemConductivityTotal.Name = "txtStemConductivityTotal";
            this.txtStemConductivityTotal.Size = new System.Drawing.Size(118, 26);
            this.txtStemConductivityTotal.TabIndex = 43;
            // 
            // txtHuberValueTotal
            // 
            this.txtHuberValueTotal.Location = new System.Drawing.Point(399, 123);
            this.txtHuberValueTotal.Name = "txtHuberValueTotal";
            this.txtHuberValueTotal.Size = new System.Drawing.Size(118, 26);
            this.txtHuberValueTotal.TabIndex = 42;
            // 
            // txtConductivityTotal
            // 
            this.txtConductivityTotal.Location = new System.Drawing.Point(399, 59);
            this.txtConductivityTotal.Name = "txtConductivityTotal";
            this.txtConductivityTotal.Size = new System.Drawing.Size(118, 26);
            this.txtConductivityTotal.TabIndex = 27;
            // 
            // txtLeafAreaTotal
            // 
            this.txtLeafAreaTotal.Location = new System.Drawing.Point(399, 155);
            this.txtLeafAreaTotal.Name = "txtLeafAreaTotal";
            this.txtLeafAreaTotal.Size = new System.Drawing.Size(118, 26);
            this.txtLeafAreaTotal.TabIndex = 41;
            // 
            // txtTotalOverview
            // 
            this.txtTotalOverview.Location = new System.Drawing.Point(399, 25);
            this.txtTotalOverview.Name = "txtTotalOverview";
            this.txtTotalOverview.Size = new System.Drawing.Size(118, 26);
            this.txtTotalOverview.TabIndex = 39;
            this.txtTotalOverview.Text = "Total";
            // 
            // txtLast300sOverview
            // 
            this.txtLast300sOverview.BackColor = System.Drawing.Color.LimeGreen;
            this.txtLast300sOverview.Location = new System.Drawing.Point(523, 25);
            this.txtLast300sOverview.Name = "txtLast300sOverview";
            this.txtLast300sOverview.Size = new System.Drawing.Size(118, 26);
            this.txtLast300sOverview.TabIndex = 38;
            this.txtLast300sOverview.Text = "Last 300 s";
            // 
            // txtGlobalResultsOverview
            // 
            this.txtGlobalResultsOverview.BackColor = System.Drawing.Color.LimeGreen;
            this.txtGlobalResultsOverview.Location = new System.Drawing.Point(132, 25);
            this.txtGlobalResultsOverview.Name = "txtGlobalResultsOverview";
            this.txtGlobalResultsOverview.Size = new System.Drawing.Size(261, 26);
            this.txtGlobalResultsOverview.TabIndex = 27;
            this.txtGlobalResultsOverview.Text = "Global Results";
            // 
            // lblCondutivityTotal
            // 
            this.lblCondutivityTotal.AutoSize = true;
            this.lblCondutivityTotal.Location = new System.Drawing.Point(169, 62);
            this.lblCondutivityTotal.Name = "lblCondutivityTotal";
            this.lblCondutivityTotal.Size = new System.Drawing.Size(224, 20);
            this.lblCondutivityTotal.TabIndex = 37;
            this.lblCondutivityTotal.Text = "Conductivity [k] (kg s-1 MPa m)";
            // 
            // lblStemConductivity
            // 
            this.lblStemConductivity.AutoSize = true;
            this.lblStemConductivity.Location = new System.Drawing.Point(121, 94);
            this.lblStemConductivity.Name = "lblStemConductivity";
            this.lblStemConductivity.Size = new System.Drawing.Size(272, 20);
            this.lblStemConductivity.TabIndex = 34;
            this.lblStemConductivity.Text = " Stem area-specivic stem conductivity";
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.BackColor = System.Drawing.Color.Orange;
            this.lblValidation.ForeColor = System.Drawing.Color.Maroon;
            this.lblValidation.Location = new System.Drawing.Point(25, 198);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(101, 20);
            this.lblValidation.TabIndex = 28;
            this.lblValidation.Text = "Validation >>";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BackColor = System.Drawing.Color.Lime;
            this.lblResults.Location = new System.Drawing.Point(41, 62);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(85, 20);
            this.lblResults.TabIndex = 27;
            this.lblResults.Text = "Results >>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 1195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btnTerminerExperience
            // 
            this.btnTerminerExperience.Location = new System.Drawing.Point(2140, 1086);
            this.btnTerminerExperience.Name = "btnTerminerExperience";
            this.btnTerminerExperience.Size = new System.Drawing.Size(101, 56);
            this.btnTerminerExperience.TabIndex = 0;
            this.btnTerminerExperience.Text = "Terminer l\'experience";
            this.btnTerminerExperience.UseVisualStyleBackColor = true;
            // 
            // grbEchantillon
            // 
            this.grbEchantillon.Controls.Add(this.btnGestionEchantillon);
            this.grbEchantillon.Controls.Add(this.btnValiderEchantillon);
            this.grbEchantillon.Controls.Add(this.btnModifierEchantillon);
            this.grbEchantillon.Controls.Add(this.txtSolutionPerfusion);
            this.grbEchantillon.Controls.Add(this.txtLongueurSegment);
            this.grbEchantillon.Controls.Add(this.lblDiametreSegment1);
            this.grbEchantillon.Controls.Add(this.lblLongueurSegment);
            this.grbEchantillon.Controls.Add(this.lblDiametreSegment2);
            this.grbEchantillon.Controls.Add(this.txtPotentiels);
            this.grbEchantillon.Controls.Add(this.txtDiametreSegment1);
            this.grbEchantillon.Controls.Add(this.txtDiametreSegment2);
            this.grbEchantillon.Controls.Add(this.cmbStressApplication);
            this.grbEchantillon.Controls.Add(this.txtAgeArbre);
            this.grbEchantillon.Controls.Add(this.txtAgeEchantillon);
            this.grbEchantillon.Controls.Add(this.txtEssence);
            this.grbEchantillon.Controls.Add(this.label21);
            this.grbEchantillon.Controls.Add(this.lblStressApplication);
            this.grbEchantillon.Controls.Add(this.lblPotentiels);
            this.grbEchantillon.Controls.Add(this.lblAgeArbre);
            this.grbEchantillon.Controls.Add(this.lblAgeEchantillon);
            this.grbEchantillon.Controls.Add(this.lblSolulionPerfusion);
            this.grbEchantillon.Controls.Add(this.lblEssence);
            this.grbEchantillon.Location = new System.Drawing.Point(16, 874);
            this.grbEchantillon.Name = "grbEchantillon";
            this.grbEchantillon.Size = new System.Drawing.Size(721, 270);
            this.grbEchantillon.TabIndex = 1;
            this.grbEchantillon.TabStop = false;
            this.grbEchantillon.Text = "Echantillon";
            // 
            // btnGestionEchantillon
            // 
            this.btnGestionEchantillon.Location = new System.Drawing.Point(320, 217);
            this.btnGestionEchantillon.Name = "btnGestionEchantillon";
            this.btnGestionEchantillon.Size = new System.Drawing.Size(121, 44);
            this.btnGestionEchantillon.TabIndex = 27;
            this.btnGestionEchantillon.Text = "Gestion";
            this.btnGestionEchantillon.UseVisualStyleBackColor = true;
            // 
            // btnValiderEchantillon
            // 
            this.btnValiderEchantillon.Location = new System.Drawing.Point(574, 217);
            this.btnValiderEchantillon.Name = "btnValiderEchantillon";
            this.btnValiderEchantillon.Size = new System.Drawing.Size(121, 44);
            this.btnValiderEchantillon.TabIndex = 26;
            this.btnValiderEchantillon.Text = "Valider";
            this.btnValiderEchantillon.UseVisualStyleBackColor = true;
            this.btnValiderEchantillon.Click += new System.EventHandler(this.btnValiderEchantillon_Click);
            // 
            // btnModifierEchantillon
            // 
            this.btnModifierEchantillon.Location = new System.Drawing.Point(447, 217);
            this.btnModifierEchantillon.Name = "btnModifierEchantillon";
            this.btnModifierEchantillon.Size = new System.Drawing.Size(121, 44);
            this.btnModifierEchantillon.TabIndex = 25;
            this.btnModifierEchantillon.Text = "Modifier";
            this.btnModifierEchantillon.UseVisualStyleBackColor = true;
            this.btnModifierEchantillon.Click += new System.EventHandler(this.btnModifierEchantillon_Click);
            // 
            // txtSolutionPerfusion
            // 
            this.txtSolutionPerfusion.Location = new System.Drawing.Point(164, 129);
            this.txtSolutionPerfusion.Name = "txtSolutionPerfusion";
            this.txtSolutionPerfusion.ReadOnly = true;
            this.txtSolutionPerfusion.Size = new System.Drawing.Size(163, 26);
            this.txtSolutionPerfusion.TabIndex = 24;
            // 
            // txtLongueurSegment
            // 
            this.txtLongueurSegment.Location = new System.Drawing.Point(532, 133);
            this.txtLongueurSegment.Name = "txtLongueurSegment";
            this.txtLongueurSegment.ReadOnly = true;
            this.txtLongueurSegment.Size = new System.Drawing.Size(163, 26);
            this.txtLongueurSegment.TabIndex = 23;
            // 
            // lblDiametreSegment1
            // 
            this.lblDiametreSegment1.AutoSize = true;
            this.lblDiametreSegment1.Location = new System.Drawing.Point(362, 69);
            this.lblDiametreSegment1.Name = "lblDiametreSegment1";
            this.lblDiametreSegment1.Size = new System.Drawing.Size(164, 20);
            this.lblDiametreSegment1.TabIndex = 22;
            this.lblDiametreSegment1.Text = "Diametre Segment 1 :";
            // 
            // lblLongueurSegment
            // 
            this.lblLongueurSegment.AutoSize = true;
            this.lblLongueurSegment.Location = new System.Drawing.Point(372, 133);
            this.lblLongueurSegment.Name = "lblLongueurSegment";
            this.lblLongueurSegment.Size = new System.Drawing.Size(154, 20);
            this.lblLongueurSegment.TabIndex = 21;
            this.lblLongueurSegment.Text = "Longueur Segment :";
            // 
            // lblDiametreSegment2
            // 
            this.lblDiametreSegment2.AutoSize = true;
            this.lblDiametreSegment2.Location = new System.Drawing.Point(365, 101);
            this.lblDiametreSegment2.Name = "lblDiametreSegment2";
            this.lblDiametreSegment2.Size = new System.Drawing.Size(161, 20);
            this.lblDiametreSegment2.TabIndex = 20;
            this.lblDiametreSegment2.Text = "Diametre segment 2 :";
            // 
            // txtPotentiels
            // 
            this.txtPotentiels.Location = new System.Drawing.Point(532, 34);
            this.txtPotentiels.Name = "txtPotentiels";
            this.txtPotentiels.ReadOnly = true;
            this.txtPotentiels.Size = new System.Drawing.Size(163, 26);
            this.txtPotentiels.TabIndex = 19;
            // 
            // txtDiametreSegment1
            // 
            this.txtDiametreSegment1.Location = new System.Drawing.Point(532, 66);
            this.txtDiametreSegment1.Name = "txtDiametreSegment1";
            this.txtDiametreSegment1.ReadOnly = true;
            this.txtDiametreSegment1.Size = new System.Drawing.Size(163, 26);
            this.txtDiametreSegment1.TabIndex = 18;
            // 
            // txtDiametreSegment2
            // 
            this.txtDiametreSegment2.Location = new System.Drawing.Point(532, 98);
            this.txtDiametreSegment2.Name = "txtDiametreSegment2";
            this.txtDiametreSegment2.ReadOnly = true;
            this.txtDiametreSegment2.Size = new System.Drawing.Size(163, 26);
            this.txtDiametreSegment2.TabIndex = 17;
            // 
            // cmbStressApplication
            // 
            this.cmbStressApplication.FormattingEnabled = true;
            this.cmbStressApplication.Location = new System.Drawing.Point(164, 163);
            this.cmbStressApplication.Name = "cmbStressApplication";
            this.cmbStressApplication.Size = new System.Drawing.Size(163, 28);
            this.cmbStressApplication.TabIndex = 16;
            // 
            // txtAgeArbre
            // 
            this.txtAgeArbre.Location = new System.Drawing.Point(164, 65);
            this.txtAgeArbre.Name = "txtAgeArbre";
            this.txtAgeArbre.ReadOnly = true;
            this.txtAgeArbre.Size = new System.Drawing.Size(163, 26);
            this.txtAgeArbre.TabIndex = 15;
            // 
            // txtAgeEchantillon
            // 
            this.txtAgeEchantillon.Location = new System.Drawing.Point(164, 97);
            this.txtAgeEchantillon.Name = "txtAgeEchantillon";
            this.txtAgeEchantillon.ReadOnly = true;
            this.txtAgeEchantillon.Size = new System.Drawing.Size(163, 26);
            this.txtAgeEchantillon.TabIndex = 14;
            // 
            // txtEssence
            // 
            this.txtEssence.Location = new System.Drawing.Point(164, 33);
            this.txtEssence.Name = "txtEssence";
            this.txtEssence.ReadOnly = true;
            this.txtEssence.Size = new System.Drawing.Size(163, 26);
            this.txtEssence.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(416, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 20);
            this.label21.TabIndex = 8;
            // 
            // lblStressApplication
            // 
            this.lblStressApplication.AutoSize = true;
            this.lblStressApplication.Location = new System.Drawing.Point(13, 166);
            this.lblStressApplication.Name = "lblStressApplication";
            this.lblStressApplication.Size = new System.Drawing.Size(145, 20);
            this.lblStressApplication.TabIndex = 6;
            this.lblStressApplication.Text = "Stress Application :";
            // 
            // lblPotentiels
            // 
            this.lblPotentiels.AutoSize = true;
            this.lblPotentiels.Location = new System.Drawing.Point(439, 37);
            this.lblPotentiels.Name = "lblPotentiels";
            this.lblPotentiels.Size = new System.Drawing.Size(87, 20);
            this.lblPotentiels.TabIndex = 5;
            this.lblPotentiels.Text = "Potentiels :";
            // 
            // lblAgeArbre
            // 
            this.lblAgeArbre.AutoSize = true;
            this.lblAgeArbre.Location = new System.Drawing.Point(69, 68);
            this.lblAgeArbre.Name = "lblAgeArbre";
            this.lblAgeArbre.Size = new System.Drawing.Size(89, 20);
            this.lblAgeArbre.TabIndex = 4;
            this.lblAgeArbre.Text = "Age Arbre :";
            // 
            // lblAgeEchantillon
            // 
            this.lblAgeEchantillon.AutoSize = true;
            this.lblAgeEchantillon.Location = new System.Drawing.Point(30, 100);
            this.lblAgeEchantillon.Name = "lblAgeEchantillon";
            this.lblAgeEchantillon.Size = new System.Drawing.Size(128, 20);
            this.lblAgeEchantillon.TabIndex = 3;
            this.lblAgeEchantillon.Text = "Age Echantillon :";
            // 
            // lblSolulionPerfusion
            // 
            this.lblSolulionPerfusion.AutoSize = true;
            this.lblSolulionPerfusion.Location = new System.Drawing.Point(12, 132);
            this.lblSolulionPerfusion.Name = "lblSolulionPerfusion";
            this.lblSolulionPerfusion.Size = new System.Drawing.Size(146, 20);
            this.lblSolulionPerfusion.TabIndex = 2;
            this.lblSolulionPerfusion.Text = "Solution Perfusion :";
            // 
            // lblEssence
            // 
            this.lblEssence.AutoSize = true;
            this.lblEssence.Location = new System.Drawing.Point(79, 36);
            this.lblEssence.Name = "lblEssence";
            this.lblEssence.Size = new System.Drawing.Size(79, 20);
            this.lblEssence.TabIndex = 1;
            this.lblEssence.Text = "Essence :";
            // 
            // grbExperience
            // 
            this.grbExperience.Controls.Add(this.btnModifierExperience);
            this.grbExperience.Controls.Add(this.btnValiderExperience);
            this.grbExperience.Controls.Add(this.rtxbDescription);
            this.grbExperience.Controls.Add(this.lblDateExperience);
            this.grbExperience.Controls.Add(this.txtXylem);
            this.grbExperience.Controls.Add(this.txtDateExperience);
            this.grbExperience.Controls.Add(this.txtExperience);
            this.grbExperience.Controls.Add(this.lblXylem);
            this.grbExperience.Controls.Add(this.lblDescription);
            this.grbExperience.Controls.Add(this.lblExperience);
            this.grbExperience.Location = new System.Drawing.Point(1261, 875);
            this.grbExperience.Name = "grbExperience";
            this.grbExperience.Size = new System.Drawing.Size(575, 270);
            this.grbExperience.TabIndex = 29;
            this.grbExperience.TabStop = false;
            this.grbExperience.Text = "Expérience";
            // 
            // btnModifierExperience
            // 
            this.btnModifierExperience.Location = new System.Drawing.Point(319, 217);
            this.btnModifierExperience.Name = "btnModifierExperience";
            this.btnModifierExperience.Size = new System.Drawing.Size(121, 44);
            this.btnModifierExperience.TabIndex = 35;
            this.btnModifierExperience.Text = "Modifier";
            this.btnModifierExperience.UseVisualStyleBackColor = true;
            this.btnModifierExperience.Click += new System.EventHandler(this.btnModifierExperience_Click);
            // 
            // btnValiderExperience
            // 
            this.btnValiderExperience.Location = new System.Drawing.Point(446, 217);
            this.btnValiderExperience.Name = "btnValiderExperience";
            this.btnValiderExperience.Size = new System.Drawing.Size(121, 44);
            this.btnValiderExperience.TabIndex = 36;
            this.btnValiderExperience.Text = "Valider";
            this.btnValiderExperience.UseVisualStyleBackColor = true;
            this.btnValiderExperience.Click += new System.EventHandler(this.btnValiderExperience_Click);
            // 
            // rtxbDescription
            // 
            this.rtxbDescription.Location = new System.Drawing.Point(168, 135);
            this.rtxbDescription.Name = "rtxbDescription";
            this.rtxbDescription.ReadOnly = true;
            this.rtxbDescription.Size = new System.Drawing.Size(399, 76);
            this.rtxbDescription.TabIndex = 34;
            this.rtxbDescription.Text = "";
            // 
            // lblDateExperience
            // 
            this.lblDateExperience.AutoSize = true;
            this.lblDateExperience.Location = new System.Drawing.Point(1, 103);
            this.lblDateExperience.Name = "lblDateExperience";
            this.lblDateExperience.Size = new System.Drawing.Size(161, 20);
            this.lblDateExperience.TabIndex = 33;
            this.lblDateExperience.Text = "Date de l\'experience :";
            // 
            // txtXylem
            // 
            this.txtXylem.Location = new System.Drawing.Point(168, 68);
            this.txtXylem.Name = "txtXylem";
            this.txtXylem.ReadOnly = true;
            this.txtXylem.Size = new System.Drawing.Size(163, 26);
            this.txtXylem.TabIndex = 32;
            // 
            // txtDateExperience
            // 
            this.txtDateExperience.Location = new System.Drawing.Point(168, 100);
            this.txtDateExperience.Name = "txtDateExperience";
            this.txtDateExperience.ReadOnly = true;
            this.txtDateExperience.Size = new System.Drawing.Size(163, 26);
            this.txtDateExperience.TabIndex = 31;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(168, 36);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.ReadOnly = true;
            this.txtExperience.Size = new System.Drawing.Size(163, 26);
            this.txtExperience.TabIndex = 30;
            // 
            // lblXylem
            // 
            this.lblXylem.AutoSize = true;
            this.lblXylem.Location = new System.Drawing.Point(102, 71);
            this.lblXylem.Name = "lblXylem";
            this.lblXylem.Size = new System.Drawing.Size(60, 20);
            this.lblXylem.TabIndex = 28;
            this.lblXylem.Text = "Xylem :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 138);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 20);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description :";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(66, 39);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(96, 20);
            this.lblExperience.TabIndex = 25;
            this.lblExperience.Text = "Experience :";
            // 
            // grbMateriel
            // 
            this.grbMateriel.Controls.Add(this.btnValiderMateriel);
            this.grbMateriel.Controls.Add(this.btnModifierMateriel);
            this.grbMateriel.Controls.Add(this.lblID_Arduino);
            this.grbMateriel.Controls.Add(this.txtID_Arduino);
            this.grbMateriel.Controls.Add(this.lblNomPc);
            this.grbMateriel.Controls.Add(this.txtNomPc);
            this.grbMateriel.Controls.Add(this.lblID_drf);
            this.grbMateriel.Controls.Add(this.txtID_drf);
            this.grbMateriel.Controls.Add(this.txtID_Pc);
            this.grbMateriel.Controls.Add(this.lblID_Pc);
            this.grbMateriel.Location = new System.Drawing.Point(1842, 875);
            this.grbMateriel.Name = "grbMateriel";
            this.grbMateriel.Size = new System.Drawing.Size(292, 269);
            this.grbMateriel.TabIndex = 30;
            this.grbMateriel.TabStop = false;
            this.grbMateriel.Text = "Matériel";
            // 
            // btnValiderMateriel
            // 
            this.btnValiderMateriel.Location = new System.Drawing.Point(147, 219);
            this.btnValiderMateriel.Name = "btnValiderMateriel";
            this.btnValiderMateriel.Size = new System.Drawing.Size(121, 44);
            this.btnValiderMateriel.TabIndex = 39;
            this.btnValiderMateriel.Text = "Valider";
            this.btnValiderMateriel.UseVisualStyleBackColor = true;
            this.btnValiderMateriel.Click += new System.EventHandler(this.btnValiderMateriel_Click);
            // 
            // btnModifierMateriel
            // 
            this.btnModifierMateriel.Location = new System.Drawing.Point(20, 219);
            this.btnModifierMateriel.Name = "btnModifierMateriel";
            this.btnModifierMateriel.Size = new System.Drawing.Size(121, 44);
            this.btnModifierMateriel.TabIndex = 38;
            this.btnModifierMateriel.Text = "Modifier";
            this.btnModifierMateriel.UseVisualStyleBackColor = true;
            this.btnModifierMateriel.Click += new System.EventHandler(this.btnModifierMateriel_Click);
            // 
            // lblID_Arduino
            // 
            this.lblID_Arduino.AutoSize = true;
            this.lblID_Arduino.Location = new System.Drawing.Point(6, 166);
            this.lblID_Arduino.Name = "lblID_Arduino";
            this.lblID_Arduino.Size = new System.Drawing.Size(90, 20);
            this.lblID_Arduino.TabIndex = 37;
            this.lblID_Arduino.Text = "Id Arduino :";
            // 
            // txtID_Arduino
            // 
            this.txtID_Arduino.Location = new System.Drawing.Point(102, 163);
            this.txtID_Arduino.Name = "txtID_Arduino";
            this.txtID_Arduino.ReadOnly = true;
            this.txtID_Arduino.Size = new System.Drawing.Size(166, 26);
            this.txtID_Arduino.TabIndex = 36;
            // 
            // lblNomPc
            // 
            this.lblNomPc.AutoSize = true;
            this.lblNomPc.Location = new System.Drawing.Point(24, 79);
            this.lblNomPc.Name = "lblNomPc";
            this.lblNomPc.Size = new System.Drawing.Size(72, 20);
            this.lblNomPc.TabIndex = 35;
            this.lblNomPc.Text = "Nom Pc :";
            // 
            // txtNomPc
            // 
            this.txtNomPc.Location = new System.Drawing.Point(102, 76);
            this.txtNomPc.Name = "txtNomPc";
            this.txtNomPc.ReadOnly = true;
            this.txtNomPc.Size = new System.Drawing.Size(166, 26);
            this.txtNomPc.TabIndex = 34;
            // 
            // lblID_drf
            // 
            this.lblID_drf.AutoSize = true;
            this.lblID_drf.Location = new System.Drawing.Point(38, 124);
            this.lblID_drf.Name = "lblID_drf";
            this.lblID_drf.Size = new System.Drawing.Size(58, 20);
            this.lblID_drf.TabIndex = 33;
            this.lblID_drf.Text = "Id drf : ";
            // 
            // txtID_drf
            // 
            this.txtID_drf.Location = new System.Drawing.Point(102, 121);
            this.txtID_drf.Name = "txtID_drf";
            this.txtID_drf.ReadOnly = true;
            this.txtID_drf.Size = new System.Drawing.Size(166, 26);
            this.txtID_drf.TabIndex = 8;
            // 
            // txtID_Pc
            // 
            this.txtID_Pc.Location = new System.Drawing.Point(102, 31);
            this.txtID_Pc.Name = "txtID_Pc";
            this.txtID_Pc.ReadOnly = true;
            this.txtID_Pc.Size = new System.Drawing.Size(166, 26);
            this.txtID_Pc.TabIndex = 32;
            // 
            // lblID_Pc
            // 
            this.lblID_Pc.AutoSize = true;
            this.lblID_Pc.Location = new System.Drawing.Point(39, 34);
            this.lblID_Pc.Name = "lblID_Pc";
            this.lblID_Pc.Size = new System.Drawing.Size(57, 20);
            this.lblID_Pc.TabIndex = 31;
            this.lblID_Pc.Text = "Id Pc : ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmXylem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2250, 1156);
            this.Controls.Add(this.grbMateriel);
            this.Controls.Add(this.grbExperience);
            this.Controls.Add(grbPeekTube);
            this.Controls.Add(this.grbEchantillon);
            this.Controls.Add(this.btnTerminerExperience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmXylem";
            this.Text = "Xylem";
            this.Load += new System.EventHandler(this.Form1_Load);
            grbPeekTube.ResumeLayout(false);
            grbPeekTube.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.grbConnexionArduino.ResumeLayout(false);
            this.grbConnexion.ResumeLayout(false);
            this.grbConnexion.PerformLayout();
            this.tabCalibration.ResumeLayout(false);
            this.tabCalibration.PerformLayout();
            this.grbDiagrammeCalibration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtP2Calibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtP1Calibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCalibration)).EndInit();
            this.tabExperimentation.ResumeLayout(false);
            this.tabExperimentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExperiementation)).EndInit();
            this.tabPressureSensorCalibration.ResumeLayout(false);
            this.grbDiagrammePression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grbP2.ResumeLayout(false);
            this.grbP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2Secondaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP2)).EndInit();
            this.grbP1.ResumeLayout(false);
            this.grbP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1Secondaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).EndInit();
            this.tabSingleKmeasurement.ResumeLayout(false);
            this.grbResults.ResumeLayout(false);
            this.grbResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grbStep.ResumeLayout(false);
            this.grbStep.PerformLayout();
            this.grbOverview.ResumeLayout(false);
            this.grbOverview.PerformLayout();
            this.grbCalibrationOverview.ResumeLayout(false);
            this.grbCalibrationOverview.PerformLayout();
            this.grbEchantillon.ResumeLayout(false);
            this.grbEchantillon.PerformLayout();
            this.grbExperience.ResumeLayout(false);
            this.grbExperience.PerformLayout();
            this.grbMateriel.ResumeLayout(false);
            this.grbMateriel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabCalibration;
        private System.Windows.Forms.DataGridView dgvDataCalibration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TabPage tabExperimentation;
        private System.Windows.Forms.DataGridView dgvDataExperiementation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStepCalibration;
        private System.Windows.Forms.TabPage tabPressureSensorCalibration;
        private System.Windows.Forms.GroupBox grbP2;
        private System.Windows.Forms.DataGridView dgvP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.GroupBox grbP1;
        private System.Windows.Forms.DataGridView dgvP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.TabPage tabSingleKmeasurement;
        private System.Windows.Forms.Button btnTerminerExperience;
        private System.Windows.Forms.TextBox txtSlopeP1;
        private System.Windows.Forms.Label lblSlopeP1;
        private System.Windows.Forms.TextBox txtRcarreOkP1;
        private System.Windows.Forms.DataGridView dgvP1Secondaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TextBox txtCvOkP1;
        private System.Windows.Forms.TextBox txtInterceptP1;
        private System.Windows.Forms.TextBox txtRcarrerP1;
        private System.Windows.Forms.Label lblInterceptP1;
        private System.Windows.Forms.Label lblRcarrerP1;
        private System.Windows.Forms.TextBox txtInterceptP2;
        private System.Windows.Forms.TextBox txtRcarrerP2;
        private System.Windows.Forms.TextBox txtSlopeP2;
        private System.Windows.Forms.Label lblInterceptP2;
        private System.Windows.Forms.Label lblRcarrerP2;
        private System.Windows.Forms.Label lblSlopeP2;
        private System.Windows.Forms.TextBox txtRcarreOkP2;
        private System.Windows.Forms.DataGridView dgvP2Secondaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.TextBox txtCvOkP2;
        private System.Windows.Forms.Button btnCvOkCalibration;
        private System.Windows.Forms.Button btnModifierDataCalibration;
        private System.Windows.Forms.Button btnEffacerDataCalibration;
        private System.Windows.Forms.TextBox txtLumiereStepCalibration;
        private System.Windows.Forms.GroupBox grbDiagrammeCalibration;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox grbEchantillon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblStressApplication;
        private System.Windows.Forms.Label lblPotentiels;
        private System.Windows.Forms.Label lblAgeArbre;
        private System.Windows.Forms.Label lblAgeEchantillon;
        private System.Windows.Forms.Label lblSolulionPerfusion;
        private System.Windows.Forms.Label lblEssence;
        private System.Windows.Forms.TextBox txtPotentiels;
        private System.Windows.Forms.TextBox txtDiametreSegment1;
        private System.Windows.Forms.TextBox txtDiametreSegment2;
        private System.Windows.Forms.ComboBox cmbStressApplication;
        private System.Windows.Forms.TextBox txtAgeArbre;
        private System.Windows.Forms.TextBox txtAgeEchantillon;
        private System.Windows.Forms.TextBox txtEssence;
        private System.Windows.Forms.Button btnAjouterDataCalibration;
        private System.Windows.Forms.Button btnAjouterDataExperience;
        private System.Windows.Forms.Button btnModifierDataExperience;
        private System.Windows.Forms.Button btnEffaceExperience;
        private System.Windows.Forms.TextBox txtLumiereStepExperience;
        private System.Windows.Forms.Button btnStepExperience;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox grbDiagrammePression;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnValiderEchantillon;
        private System.Windows.Forms.Button btnModifierEchantillon;
        private System.Windows.Forms.TextBox txtSolutionPerfusion;
        private System.Windows.Forms.TextBox txtLongueurSegment;
        private System.Windows.Forms.Label lblDiametreSegment1;
        private System.Windows.Forms.Label lblLongueurSegment;
        private System.Windows.Forms.Label lblDiametreSegment2;
        private System.Windows.Forms.Button btnEstValidePeekTube;
        private System.Windows.Forms.Button btnModifierPeekTube;
        private System.Windows.Forms.Button btnValiderPeekTube;
        private System.Windows.Forms.TextBox txtResistancePeekTube;
        private System.Windows.Forms.Label lblResistancePeekTube;
        private System.Windows.Forms.Label lblLongPeekTube;
        private System.Windows.Forms.TextBox txtDiamPeekTubeBleu;
        private System.Windows.Forms.TextBox txtLongPeekTubeBleu;
        private System.Windows.Forms.TextBox txtDiamPeekTubeJaune;
        private System.Windows.Forms.TextBox txtLongPeekTubeJaune;
        private System.Windows.Forms.TextBox txtLongPeekTubeOrange;
        private System.Windows.Forms.Label lblDiamPeekTube;
        private System.Windows.Forms.Label lblMPa_mmol;
        private System.Windows.Forms.RadioButton rdbCouleurBleu;
        private System.Windows.Forms.RadioButton rdbCouleurJaune;
        private System.Windows.Forms.RadioButton rdbCouleurOrange;
        private System.Windows.Forms.TextBox txtMpa_mmol_Jaune;
        private System.Windows.Forms.TextBox txtMpa_mmol_Bleu;
        private System.Windows.Forms.TextBox txtMpa_mmol_Orange;
        private System.Windows.Forms.TextBox txtDiamPeekTubeOrange;
        private System.Windows.Forms.TextBox txtColorID;
        private System.Windows.Forms.GroupBox grbStep;
        private System.Windows.Forms.GroupBox grbOverview;
        private System.Windows.Forms.TextBox txtStemConductivityTotal;
        private System.Windows.Forms.TextBox txtHuberValueTotal;
        private System.Windows.Forms.TextBox txtConductivityTotal;
        private System.Windows.Forms.TextBox txtTotalOverview;
        private System.Windows.Forms.TextBox txtLast300sOverview;
        private System.Windows.Forms.TextBox txtGlobalResultsOverview;
        private System.Windows.Forms.Label lblCondutivityTotal;
        private System.Windows.Forms.Label lblStemConductivity;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtLeafAreaTotal;
        private System.Windows.Forms.Label lblTempDownstream;
        private System.Windows.Forms.Label lblResistancePeek;
        private System.Windows.Forms.TextBox txtResistancePeekLast300s;
        private System.Windows.Forms.TextBox txtAverageTempLast300s;
        private System.Windows.Forms.TextBox txtResistancePeekTotal;
        private System.Windows.Forms.TextBox txtAverageTempTotal;
        private System.Windows.Forms.Label lblAverageTemp;
        private System.Windows.Forms.Label lblTempUpstream;
        private System.Windows.Forms.TextBox txtTempUpstreamLast300s;
        private System.Windows.Forms.TextBox txtTempDownstreamLast300s;
        private System.Windows.Forms.TextBox txtP3_P2StopcockLast300s;
        private System.Windows.Forms.TextBox txtTempUpstreamTotal;
        private System.Windows.Forms.TextBox txtTempDownstreamTotal;
        private System.Windows.Forms.TextBox txtP3_P2StopcockTotal;
        private System.Windows.Forms.Label lblP3_P2Stopcock;
        private System.Windows.Forms.Label lblCvK;
        private System.Windows.Forms.TextBox txtCvKLast300s;
        private System.Windows.Forms.TextBox txtKrought_kgLast300s;
        private System.Windows.Forms.TextBox txtCvKTotal;
        private System.Windows.Forms.TextBox txtKrought_kgTotal;
        private System.Windows.Forms.Label lblKrought_kg;
        private System.Windows.Forms.Label lblP2bar;
        private System.Windows.Forms.TextBox txtP2barLast300s;
        private System.Windows.Forms.TextBox txtKrought_mmolLast300s;
        private System.Windows.Forms.TextBox lblP1barLast300s;
        private System.Windows.Forms.Label lblKrought_mmol;
        private System.Windows.Forms.TextBox txtP2barTotal;
        private System.Windows.Forms.TextBox txtKrought_mmolTotal;
        private System.Windows.Forms.TextBox lblP1barTotal;
        private System.Windows.Forms.Label lblP1bar;
        private System.Windows.Forms.Label lblP2Validation;
        private System.Windows.Forms.TextBox txtP2ValidationLast300s;
        private System.Windows.Forms.TextBox txtAverageLast300s;
        private System.Windows.Forms.TextBox txtP1ValidationLast300s;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtP2ValidationTotal;
        private System.Windows.Forms.TextBox txtAverageTotal;
        private System.Windows.Forms.TextBox txtP1ValidationTotal;
        private System.Windows.Forms.TextBox txtTotalStep;
        private System.Windows.Forms.TextBox txtLast300sStep;
        private System.Windows.Forms.TextBox txtGlobalResultsStep;
        private System.Windows.Forms.Label lblP1Validation;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.GroupBox grbCalibrationOverview;
        private System.Windows.Forms.Label lblP2Calibration;
        private System.Windows.Forms.Label lblP1Calibration;
        private System.Windows.Forms.TextBox txtInterceptOverviewP2;
        private System.Windows.Forms.TextBox txtSlopeOverviewP2;
        private System.Windows.Forms.Label lblInterceptOverviewP2;
        private System.Windows.Forms.Label lblSlopeOverviewP2;
        private System.Windows.Forms.TextBox txtInterceptOverviewP1;
        private System.Windows.Forms.TextBox txtSlopeOverviewP1;
        private System.Windows.Forms.Label lblInterceptOverviewP1;
        private System.Windows.Forms.Label lblSlopeOverviewP1;
        private System.Windows.Forms.Label lblStability;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPresureValidation;
        private System.Windows.Forms.Label lblOptimalPeekTube;
        private System.Windows.Forms.TextBox txtPresureValidationTotal;
        private System.Windows.Forms.TextBox txtOptimalPeekTubeLast300s;
        private System.Windows.Forms.TextBox txtTimeValidation;
        private System.Windows.Forms.TextBox txtPresureValidationLast300s;
        private System.Windows.Forms.TextBox txtStabilityLast300s;
        private System.Windows.Forms.TextBox txtOptimalPeekTubeTotal;
        private System.Windows.Forms.TextBox txtStemConductivityLast300s;
        private System.Windows.Forms.TextBox txtHuberValueLast300s;
        private System.Windows.Forms.TextBox txtConductivityLast300s;
        private System.Windows.Forms.TextBox txtLeafAreaLast300s;
        private System.Windows.Forms.Label lblLeafArea;
        private System.Windows.Forms.Label lblHuberValue;
        private System.Windows.Forms.Label lblTempWaterBassin;
        private System.Windows.Forms.TextBox txtTempWaterBassinLast300s;
        private System.Windows.Forms.TextBox txtTempWaterBassinTotal;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.TextBox txtTotalResults;
        private System.Windows.Forms.TextBox txtLast300sResults;
        private System.Windows.Forms.TextBox txtGlobalResults;
        private System.Windows.Forms.Label lblStepHuberValue;
        private System.Windows.Forms.TextBox txtLeafAreaStemConductivityLast300s;
        private System.Windows.Forms.TextBox txtLeafAreaStemConductivityTotal;
        private System.Windows.Forms.Label lblLeafAreaStemConductivity;
        private System.Windows.Forms.Label lblStepStemConductivity;
        private System.Windows.Forms.TextBox txtStepStemConductivityLast300s;
        private System.Windows.Forms.TextBox txtStepHuberValueLast300s;
        private System.Windows.Forms.TextBox txtStepConductivityLast300s;
        private System.Windows.Forms.TextBox txtStepStemConductivityTotal;
        private System.Windows.Forms.TextBox txtStepHuberValueTotal;
        private System.Windows.Forms.TextBox txtStepConductivityTotal;
        private System.Windows.Forms.Label lblConductivity;
        private System.Windows.Forms.Label lblK25oCP3;
        private System.Windows.Forms.TextBox txtK25oCP3Last300s;
        private System.Windows.Forms.TextBox txtKCorrectedP3Last300s;
        private System.Windows.Forms.TextBox txtK25oCP3Total;
        private System.Windows.Forms.TextBox txtKCorrectedP3Total;
        private System.Windows.Forms.Label lblKCorrectedP3;
        private System.Windows.Forms.GroupBox grbExperience;
        private System.Windows.Forms.Button btnModifierExperience;
        private System.Windows.Forms.Button btnValiderExperience;
        private System.Windows.Forms.RichTextBox rtxbDescription;
        private System.Windows.Forms.Label lblDateExperience;
        private System.Windows.Forms.TextBox txtXylem;
        private System.Windows.Forms.TextBox txtDateExperience;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblXylem;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.GroupBox grbMateriel;
        private System.Windows.Forms.Label lblNomPc;
        private System.Windows.Forms.TextBox txtNomPc;
        private System.Windows.Forms.Label lblID_drf;
        private System.Windows.Forms.TextBox txtID_drf;
        private System.Windows.Forms.TextBox txtID_Pc;
        private System.Windows.Forms.Label lblID_Pc;
        private System.Windows.Forms.Button btnGestionEchantillon;
        private System.Windows.Forms.Button btnValiderMateriel;
        private System.Windows.Forms.Button btnModifierMateriel;
        private System.Windows.Forms.Label lblID_Arduino;
        private System.Windows.Forms.TextBox txtID_Arduino;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblUtiilisateur;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateDuJour;
        private System.Windows.Forms.GroupBox grbConnexion;
        private System.Windows.Forms.TextBox txtLoginIdPc;
        private System.Windows.Forms.Label lblArduinoLogin;
        private System.Windows.Forms.TextBox txtLoginArduino;
        private System.Windows.Forms.Label lblConnexionOrdinateur;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtP2Calibration;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtP1Calibration;
        private System.Windows.Forms.GroupBox grbConnexionArduino;
        private System.Windows.Forms.Button btnDeconnexionArduino;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnexionArduino;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStartMesure;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSeconde;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
    }
}

