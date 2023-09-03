// Developer Express Code Central Example:
// How to use All-Day header to display scheduled time statistics
// 
// Problem : It would be good to display how much time you have in use (% wise) in
// your schedule. When an appointment is added/changed/deleted for each resource it
// will calculate the appointments on the days that have been changed against your
// total time available and get a % which will be added to the top of the schedule.
// When you have less than 50% available it will show yellow and when you go over
// 50% it will show in red. Solution: You can utilize the
// SchedulerControl.CustomDrawDayViewAllDayArea event to draw this statistics in
// the All-Day appointments area. Then, you can collect appointments for a
// particular day via the SchedulerStorageBase.GetAppointments method. This
// approach is illustrated by the following example.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E121

namespace iEvent
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
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema1 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema2 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema3 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema4 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema5 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema6 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema7 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema8 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema9 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema10 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema11 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema12 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScaleFixedInterval timeScaleFixedInterval1 = new DevExpress.XtraScheduler.TimeScaleFixedInterval();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.viewNavigatorBackwardItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem();
            this.viewNavigatorForwardItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem();
            this.viewNavigatorTodayItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem();
            this.viewNavigatorZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem();
            this.viewNavigatorZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem();
            this.viewSelectorItem1 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem2 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem3 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem4 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.viewSelectorItem5 = new DevExpress.XtraScheduler.UI.ViewSelectorItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.viewNavigatorRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewNavigatorRibbonPage();
            this.viewNavigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ViewNavigatorRibbonPageGroup();
            this.viewSelectorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ViewSelectorRibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.xpCollection2 = new DevExpress.Xpo.XPCollection();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonViewNavigator1 = new DevExpress.XtraScheduler.UI.RibbonViewNavigator();
            this.ribbonViewSelector1 = new DevExpress.XtraScheduler.UI.RibbonViewSelector(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonViewNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonViewSelector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 148);
            this.schedulerControl1.LookAndFeel.SkinName = "Black";
            this.schedulerControl1.MenuManager = this.ribbonControl1;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsBehavior.SelectOnRightClick = true;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.Custom;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl1.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always;
            schedulerColorSchema1.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(219)))), ((int)(((byte)(162)))));
            schedulerColorSchema1.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(213)))));
            schedulerColorSchema1.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(213)))));
            schedulerColorSchema1.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(219)))), ((int)(((byte)(162)))));
            schedulerColorSchema1.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(199)))));
            schedulerColorSchema1.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(219)))), ((int)(((byte)(162)))));
            schedulerColorSchema2.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(203)))), ((int)(((byte)(138)))));
            schedulerColorSchema2.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(203)))), ((int)(((byte)(138)))));
            schedulerColorSchema2.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(104)))));
            schedulerColorSchema2.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(203)))), ((int)(((byte)(138)))));
            schedulerColorSchema2.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(180)))));
            schedulerColorSchema2.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(162)))));
            schedulerColorSchema3.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(113)))));
            schedulerColorSchema3.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(113)))));
            schedulerColorSchema3.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(131)))), ((int)(((byte)(71)))));
            schedulerColorSchema3.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(113)))));
            schedulerColorSchema3.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(196)))), ((int)(((byte)(163)))));
            schedulerColorSchema3.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(118)))));
            schedulerColorSchema4.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            schedulerColorSchema4.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            schedulerColorSchema4.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            schedulerColorSchema4.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            schedulerColorSchema4.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            schedulerColorSchema4.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            schedulerColorSchema5.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(124)))), ((int)(((byte)(149)))));
            schedulerColorSchema5.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(124)))), ((int)(((byte)(149)))));
            schedulerColorSchema5.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            schedulerColorSchema5.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(124)))), ((int)(((byte)(149)))));
            schedulerColorSchema5.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            schedulerColorSchema5.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(163)))), ((int)(((byte)(171)))));
            schedulerColorSchema6.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(136)))), ((int)(((byte)(194)))));
            schedulerColorSchema6.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(136)))), ((int)(((byte)(194)))));
            schedulerColorSchema6.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            schedulerColorSchema6.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(136)))), ((int)(((byte)(194)))));
            schedulerColorSchema6.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            schedulerColorSchema6.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            schedulerColorSchema7.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            schedulerColorSchema7.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            schedulerColorSchema7.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(116)))), ((int)(((byte)(152)))));
            schedulerColorSchema7.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(147)))), ((int)(((byte)(181)))));
            schedulerColorSchema7.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            schedulerColorSchema7.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            schedulerColorSchema8.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(168)))), ((int)(((byte)(156)))));
            schedulerColorSchema8.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(168)))), ((int)(((byte)(156)))));
            schedulerColorSchema8.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(142)))), ((int)(((byte)(128)))));
            schedulerColorSchema8.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(168)))), ((int)(((byte)(156)))));
            schedulerColorSchema8.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(195)))));
            schedulerColorSchema8.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(173)))));
            schedulerColorSchema9.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            schedulerColorSchema9.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            schedulerColorSchema9.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))));
            schedulerColorSchema9.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            schedulerColorSchema9.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            schedulerColorSchema9.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(203)))), ((int)(((byte)(204)))));
            schedulerColorSchema10.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(138)))), ((int)(((byte)(122)))));
            schedulerColorSchema10.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(138)))), ((int)(((byte)(122)))));
            schedulerColorSchema10.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            schedulerColorSchema10.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(138)))), ((int)(((byte)(122)))));
            schedulerColorSchema10.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(207)))), ((int)(((byte)(191)))));
            schedulerColorSchema10.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(181)))), ((int)(((byte)(169)))));
            schedulerColorSchema11.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            schedulerColorSchema11.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            schedulerColorSchema11.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            schedulerColorSchema11.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            schedulerColorSchema11.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            schedulerColorSchema11.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            schedulerColorSchema12.Cell = System.Drawing.SystemColors.Window;
            schedulerColorSchema12.CellBorder = System.Drawing.SystemColors.ControlDark;
            schedulerColorSchema12.CellBorderDark = System.Drawing.SystemColors.ControlDark;
            schedulerColorSchema12.CellLight = System.Drawing.SystemColors.Window;
            schedulerColorSchema12.CellLightBorder = System.Drawing.SystemColors.ControlDark;
            schedulerColorSchema12.CellLightBorderDark = System.Drawing.SystemColors.ControlDark;
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema1);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema2);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema3);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema4);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema5);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema6);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema7);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema8);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema9);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema10);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema11);
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema12);
            this.schedulerControl1.Size = new System.Drawing.Size(835, 365);
            this.schedulerControl1.Start = new System.DateTime(2007, 8, 6, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.ToolTipController = this.toolTipController1;
            this.schedulerControl1.Views.DayView.Appearance.AllDayArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedulerControl1.Views.DayView.Appearance.AllDayArea.Options.UseFont = true;
            this.schedulerControl1.Views.DayView.Appearance.AllDayArea.Options.UseTextOptions = true;
            this.schedulerControl1.Views.DayView.Appearance.AllDayArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.AppointmentHeight = 36;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.ContinueArrowDisplayType = DevExpress.XtraScheduler.AppointmentContinueArrowDisplayType.ArrowWithText;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.ShowRecurrence = false;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl1.Views.TimelineView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleDay1.DisplayFormat = "dddd dd";
            timeScaleDay1.Width = 220;
            timeScaleHour1.Enabled = false;
            timeScaleFixedInterval1.Enabled = false;
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleYear1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleQuarter1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleMonth1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleWeek1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleDay1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleHour1);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleFixedInterval1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.InitAppointmentImages += new DevExpress.XtraScheduler.AppointmentImagesEventHandler(this.schedulerControl_InitAppointmentImages);
            this.schedulerControl1.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.schedulerControl1_InitAppointmentDisplayText);
            this.schedulerControl1.PreparePopupMenu += new DevExpress.XtraScheduler.PreparePopupMenuEventHandler(this.schedulerControl1_PreparePopupMenu);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = null;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.viewNavigatorBackwardItem1,
            this.viewNavigatorForwardItem1,
            this.viewNavigatorTodayItem1,
            this.viewNavigatorZoomInItem1,
            this.viewNavigatorZoomOutItem1,
            this.viewSelectorItem1,
            this.viewSelectorItem2,
            this.viewSelectorItem3,
            this.viewSelectorItem4,
            this.viewSelectorItem5,
            this.ribbonGalleryBarItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.viewNavigatorRibbonPage1,
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.ribbonControl1.SelectedPage = this.viewNavigatorRibbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(835, 148);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.viewNavigatorBackwardItem1, "B");
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.viewNavigatorTodayItem1, "T");
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.viewNavigatorForwardItem1, "F");
            // 
            // viewNavigatorBackwardItem1
            // 
            this.viewNavigatorBackwardItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorBackwardItem1.Glyph")));
            this.viewNavigatorBackwardItem1.GroupIndex = 1;
            this.viewNavigatorBackwardItem1.Id = 0;
            this.viewNavigatorBackwardItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorBackwardItem1.LargeGlyph")));
            this.viewNavigatorBackwardItem1.Name = "viewNavigatorBackwardItem1";
            // 
            // viewNavigatorForwardItem1
            // 
            this.viewNavigatorForwardItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorForwardItem1.Glyph")));
            this.viewNavigatorForwardItem1.GroupIndex = 1;
            this.viewNavigatorForwardItem1.Id = 1;
            this.viewNavigatorForwardItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorForwardItem1.LargeGlyph")));
            this.viewNavigatorForwardItem1.Name = "viewNavigatorForwardItem1";
            // 
            // viewNavigatorTodayItem1
            // 
            this.viewNavigatorTodayItem1.Caption = "Aujourd\'hui";
            this.viewNavigatorTodayItem1.Description = "Aller à la date d\'aujourd\'hui";
            this.viewNavigatorTodayItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorTodayItem1.Glyph")));
            this.viewNavigatorTodayItem1.GroupIndex = 1;
            this.viewNavigatorTodayItem1.Id = 2;
            this.viewNavigatorTodayItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorTodayItem1.LargeGlyph")));
            this.viewNavigatorTodayItem1.Name = "viewNavigatorTodayItem1";
            // 
            // viewNavigatorZoomInItem1
            // 
            this.viewNavigatorZoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomInItem1.Glyph")));
            this.viewNavigatorZoomInItem1.GroupIndex = 1;
            this.viewNavigatorZoomInItem1.Id = 3;
            this.viewNavigatorZoomInItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            this.viewNavigatorZoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomInItem1.LargeGlyph")));
            this.viewNavigatorZoomInItem1.Name = "viewNavigatorZoomInItem1";
            // 
            // viewNavigatorZoomOutItem1
            // 
            this.viewNavigatorZoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomOutItem1.Glyph")));
            this.viewNavigatorZoomOutItem1.GroupIndex = 1;
            this.viewNavigatorZoomOutItem1.Id = 4;
            this.viewNavigatorZoomOutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract));
            this.viewNavigatorZoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewNavigatorZoomOutItem1.LargeGlyph")));
            this.viewNavigatorZoomOutItem1.Name = "viewNavigatorZoomOutItem1";
            // 
            // viewSelectorItem1
            // 
            this.viewSelectorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem1.Glyph")));
            this.viewSelectorItem1.GroupIndex = 1;
            this.viewSelectorItem1.Id = 5;
            this.viewSelectorItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D1));
            this.viewSelectorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem1.LargeGlyph")));
            this.viewSelectorItem1.Name = "viewSelectorItem1";
            this.viewSelectorItem1.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
            // 
            // viewSelectorItem2
            // 
            this.viewSelectorItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem2.Glyph")));
            this.viewSelectorItem2.GroupIndex = 1;
            this.viewSelectorItem2.Id = 6;
            this.viewSelectorItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D2));
            this.viewSelectorItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem2.LargeGlyph")));
            this.viewSelectorItem2.Name = "viewSelectorItem2";
            this.viewSelectorItem2.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            // 
            // viewSelectorItem3
            // 
            this.viewSelectorItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem3.Glyph")));
            this.viewSelectorItem3.GroupIndex = 1;
            this.viewSelectorItem3.Id = 7;
            this.viewSelectorItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D3));
            this.viewSelectorItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem3.LargeGlyph")));
            this.viewSelectorItem3.Name = "viewSelectorItem3";
            this.viewSelectorItem3.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Week;
            // 
            // viewSelectorItem4
            // 
            this.viewSelectorItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem4.Glyph")));
            this.viewSelectorItem4.GroupIndex = 1;
            this.viewSelectorItem4.Id = 8;
            this.viewSelectorItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D4));
            this.viewSelectorItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem4.LargeGlyph")));
            this.viewSelectorItem4.Name = "viewSelectorItem4";
            this.viewSelectorItem4.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            // 
            // viewSelectorItem5
            // 
            this.viewSelectorItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem5.Glyph")));
            this.viewSelectorItem5.GroupIndex = 1;
            this.viewSelectorItem5.Id = 9;
            this.viewSelectorItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                            | System.Windows.Forms.Keys.D5));
            this.viewSelectorItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewSelectorItem5.LargeGlyph")));
            this.viewSelectorItem5.Name = "viewSelectorItem5";
            this.viewSelectorItem5.SchedulerViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group1";
            galleryItemGroup2.Caption = "Group2";
            galleryItem1.Caption = "Item1";
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1});
            this.ribbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2});
            this.ribbonGalleryBarItem1.Id = 10;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "© 2010 OURBATI GROUP. LLC";
            this.barEditItem1.Description = "Powred by OURBATI GROUP";
            this.barEditItem1.Edit = this.repositoryItemHyperLinkEdit1;
            this.barEditItem1.Hint = "iEvent - Powred by OURBATI GROUP";
            this.barEditItem1.Id = 11;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barEditItem1.Width = 0;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem2.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.barEditItem2.Appearance.Options.UseForeColor = true;
            this.barEditItem2.Caption = "En ligne";
            this.barEditItem2.Description = "Etat de connexion au serveur de base de données";
            this.barEditItem2.Edit = this.repositoryItemHyperLinkEdit2;
            this.barEditItem2.Hint = "En ligne";
            this.barEditItem2.Id = 12;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 0;
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Actualiser";
            this.barButtonItem1.Glyph = global::iEvent.Properties.Resources.Refresh;
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.LargeGlyph = global::iEvent.Properties.Resources.Refresh1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Chiffre d\'affaire";
            this.barButtonItem2.Description = "Cliquer et séléctionner une plage pourafficher le chifre d\'affaire";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.LargeGlyph = global::iEvent.Properties.Resources.RocketDock;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Utilisateur";
            this.barButtonItem3.Description = "Changer le mot de l\'utilisateur ";
            this.barButtonItem3.Hint = "Changement du mot de l\'utilisateur courant";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.LargeGlyph = global::iEvent.Properties.Resources.Private1;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Location";
            this.barButtonItem4.Description = "Séléction des endroits ou vous pouvez faire des réservations";
            this.barButtonItem4.Hint = "Les endroits disponible pour les écénements";
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.LargeGlyph = global::iEvent.Properties.Resources.Burn;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // viewNavigatorRibbonPage1
            // 
            this.viewNavigatorRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewNavigatorRibbonPageGroup1,
            this.viewSelectorRibbonPageGroup1,
            this.ribbonPageGroup1});
            this.viewNavigatorRibbonPage1.KeyTip = "AC";
            this.viewNavigatorRibbonPage1.Name = "viewNavigatorRibbonPage1";
            this.viewNavigatorRibbonPage1.Text = "Accueil";
            // 
            // viewNavigatorRibbonPageGroup1
            // 
            this.viewNavigatorRibbonPageGroup1.ItemLinks.Add(this.viewNavigatorBackwardItem1, "B");
            this.viewNavigatorRibbonPageGroup1.ItemLinks.Add(this.viewNavigatorForwardItem1, "F");
            this.viewNavigatorRibbonPageGroup1.ItemLinks.Add(this.viewNavigatorTodayItem1, "TO");
            this.viewNavigatorRibbonPageGroup1.ItemLinks.Add(this.viewNavigatorZoomInItem1, "ZO");
            this.viewNavigatorRibbonPageGroup1.ItemLinks.Add(this.viewNavigatorZoomOutItem1, "ZM");
            this.viewNavigatorRibbonPageGroup1.KeyTip = "VI";
            this.viewNavigatorRibbonPageGroup1.Name = "viewNavigatorRibbonPageGroup1";
            // 
            // viewSelectorRibbonPageGroup1
            // 
            this.viewSelectorRibbonPageGroup1.ItemLinks.Add(this.viewSelectorItem1, "D");
            this.viewSelectorRibbonPageGroup1.ItemLinks.Add(this.viewSelectorItem2, "WO");
            this.viewSelectorRibbonPageGroup1.ItemLinks.Add(this.viewSelectorItem3, "WE");
            this.viewSelectorRibbonPageGroup1.ItemLinks.Add(this.viewSelectorItem4, "M");
            this.viewSelectorRibbonPageGroup1.ItemLinks.Add(this.viewSelectorItem5, "TI");
            this.viewSelectorRibbonPageGroup1.KeyTip = "VE";
            this.viewSelectorRibbonPageGroup1.Name = "viewSelectorRibbonPageGroup1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Rappels";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Outils";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sécurité";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Endroits";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 513);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(835, 23);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("tel", "tel", DevExpress.XtraScheduler.FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("fax", "fax", DevExpress.XtraScheduler.FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("pax", "pax", DevExpress.XtraScheduler.FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("email", "email", DevExpress.XtraScheduler.FieldValueType.String));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("prix", "prix"));
            this.schedulerStorage1.Appointments.DataSource = this.xpCollection1;
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))), "Déjeuner", "&Déjeuner"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))), "Diner", "Di&ner"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))), "Séminaire", "Sé&minaire"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))), "Soirée", "&Soirée"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.PaleGoldenrod, "Repérage", "&Repérage"));
            this.schedulerStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))), "Hôtel", "&Hôtel"));
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndTime";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "EmpID";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartTime";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.Type = "EventType";
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Free, System.Drawing.Color.Yellow, "Option", "&Option"));
            this.schedulerStorage1.Appointments.Statuses.Add(new DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Tentative, System.Drawing.Color.Red, "Confirmé", "&Confirmé"));
            this.schedulerStorage1.Resources.DataSource = this.xpCollection2;
            this.schedulerStorage1.Resources.Mappings.Caption = "EmpName";
            this.schedulerStorage1.Resources.Mappings.Id = "ID";
            this.schedulerStorage1.ReminderAlert += new DevExpress.XtraScheduler.ReminderEventHandler(this.schedulerStorage1_ReminderAlert);
            this.schedulerStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentsChanged);
            this.schedulerStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentsChanged);
            this.schedulerStorage1.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentsDeleted);
            this.schedulerStorage1.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage1_AppointmentDeleting);
            // 
            // xpCollection1
            // 
            this.xpCollection1.DeleteObjectOnRemove = true;
            this.xpCollection1.DisplayableProperties = "This;ID;EmpID;fax;tel;Subject;Services;Status;Description;Label;StartTime;EndTime" +
                ";Location;AllDay;EventType;RecurrenceInfo;ReminderInfo;Price;email;pax;prix";
            this.xpCollection1.ObjectType = typeof(iEvent.Reservation);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=iEvent;User ID=Rachid;Passwor" +
                "d=dilwal";
            // 
            // xpCollection2
            // 
            this.xpCollection2.DeleteObjectOnRemove = true;
            this.xpCollection2.DisplayableProperties = "This;ID;EmpName";
            this.xpCollection2.ObjectType = typeof(iEvent.Emplacement);
            this.xpCollection2.SelectDeleted = true;
            this.xpCollection2.Session = this.unitOfWork1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.toolTipController1.Appearance.BackColor2 = System.Drawing.Color.PapayaWhip;
            this.toolTipController1.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Verdana", 7.25F);
            this.toolTipController1.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolTipController1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.toolTipController1.Appearance.Options.UseBackColor = true;
            this.toolTipController1.Appearance.Options.UseBorderColor = true;
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.Appearance.Options.UseForeColor = true;
            this.toolTipController1.Appearance.Options.UseTextOptions = true;
            this.toolTipController1.AppearanceTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.AppearanceTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.toolTipController1.AppearanceTitle.Options.UseFont = true;
            this.toolTipController1.AppearanceTitle.Options.UseForeColor = true;
            this.toolTipController1.AutoPopDelay = 15000;
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ShowBeak = true;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // ribbonViewNavigator1
            // 
            this.ribbonViewNavigator1.RibbonControl = this.ribbonControl1;
            this.ribbonViewNavigator1.SchedulerControl = this.schedulerControl1;
            // 
            // ribbonViewSelector1
            // 
            this.ribbonViewSelector1.RibbonControl = this.ribbonControl1;
            this.ribbonViewSelector1.SchedulerControl = this.schedulerControl1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(15, 15);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 536);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Gestion des réservations des événements - iEvent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonViewNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonViewSelector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorBackwardItem viewNavigatorBackwardItem1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorForwardItem viewNavigatorForwardItem1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorTodayItem viewNavigatorTodayItem1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorZoomInItem viewNavigatorZoomInItem1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorZoomOutItem viewNavigatorZoomOutItem1;
        private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem1;
        private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem2;
        private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem3;
        private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem4;
        private DevExpress.XtraScheduler.UI.ViewSelectorItem viewSelectorItem5;
        private DevExpress.XtraScheduler.UI.ViewNavigatorRibbonPage viewNavigatorRibbonPage1;
        private DevExpress.XtraScheduler.UI.ViewNavigatorRibbonPageGroup viewNavigatorRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.ViewSelectorRibbonPageGroup viewSelectorRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.RibbonViewNavigator ribbonViewNavigator1;
        private DevExpress.XtraScheduler.UI.RibbonViewSelector ribbonViewSelector1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.XPCollection xpCollection2;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        
    }
}

