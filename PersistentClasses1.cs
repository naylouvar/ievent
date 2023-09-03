using System;
using DevExpress.Xpo;
namespace iEvent
{

    public class Reservation : XPObject
    {
        int fID;
        //[Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        int fEmpID;
        public int EmpID
        {
            get { return fEmpID; }
            set { SetPropertyValue<int>("EmpID", ref fEmpID, value); }
        }
        string ffax;
        [Size(50)]
        public string fax
        {
            get { return ffax; }
            set { SetPropertyValue<string>("fax", ref ffax, value); }
        }
        string ftel;
        [Size(50)]
        public string tel
        {
            get { return ftel; }
            set { SetPropertyValue<string>("tel", ref ftel, value); }
        }
        string fSubject;
        [Size(50)]
        public string Subject
        {
            get { return fSubject; }
            set { SetPropertyValue<string>("Subject", ref fSubject, value); }
        }
        string fServices;
        [Size(1073741823)]
        public string Services
        {
            get { return fServices; }
            set { SetPropertyValue<string>("Services", ref fServices, value); }
        }
        int fStatus;
        public int Status
        {
            get { return fStatus; }
            set { SetPropertyValue<int>("Status", ref fStatus, value); }
        }
        string fDescription;
        [Size(1073741823)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        int fLabel;
        public int Label
        {
            get { return fLabel; }
            set { SetPropertyValue<int>("Label", ref fLabel, value); }
        }
        DateTime fStartTime;
        public DateTime StartTime
        {
            get { return fStartTime; }
            set { SetPropertyValue<DateTime>("StartTime", ref fStartTime, value); }
        }
        DateTime fEndTime;
        public DateTime EndTime
        {
            get { return fEndTime; }
            set { SetPropertyValue<DateTime>("EndTime", ref fEndTime, value); }
        }
        string fLocation;
        [Size(50)]
        public string Location
        {
            get { return fLocation; }
            set { SetPropertyValue<string>("Location", ref fLocation, value); }
        }
        bool fAllDay;
        public bool AllDay
        {
            get { return fAllDay; }
            set { SetPropertyValue<bool>("AllDay", ref fAllDay, value); }
        }
        int fEventType;
        public int EventType
        {
            get { return fEventType; }
            set { SetPropertyValue<int>("EventType", ref fEventType, value); }
        }
        string fRecurrenceInfo;
        [Size(1073741823)]
        public string RecurrenceInfo
        {
            get { return fRecurrenceInfo; }
            set { SetPropertyValue<string>("RecurrenceInfo", ref fRecurrenceInfo, value); }
        }
        string fReminderInfo;
        [Size(1073741823)]
        public string ReminderInfo
        {
            get { return fReminderInfo; }
            set { SetPropertyValue<string>("ReminderInfo", ref fReminderInfo, value); }
        }
        int fPrice;
        public int Price
        {
            get { return fPrice; }
            set { SetPropertyValue<int>("Price", ref fPrice, value); }
        }
        string femail;
        [Size(50)]
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>("email", ref femail, value); }
        }
        int fpax;
        public int pax
        {
            get { return fpax; }
            set { SetPropertyValue<int>("pax", ref fpax, value); }
        }
        float fprix;
        public float prix
        {
            get { return fprix; }
            set { SetPropertyValue<float>("prix", ref fprix, value); }
        }
        public Reservation(Session session) : base(session) { }
        public Reservation() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class User : XPLiteObject
    {
        int fLogID;
        [Key(true)]
        public int LogID
        {
            get { return fLogID; }
            set { SetPropertyValue<int>("LogID", ref fLogID, value); }
        }
        string fLogin;
        [Size(50)]
        public string Login
        {
            get { return fLogin; }
            set { SetPropertyValue<string>("Login", ref fLogin, value); }
        }
        string fPassword;
        [Size(255)]
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>("Password", ref fPassword, value); }
        }
        string fNom;
        [Size(50)]
        public string Nom
        {
            get { return fNom; }
            set { SetPropertyValue<string>("Nom", ref fNom, value); }
        }
        string fPrenom;
        [Size(50)]
        public string Prenom
        {
            get { return fPrenom; }
            set { SetPropertyValue<string>("Prenom", ref fPrenom, value); }
        }
        string fTel;
        [Size(50)]
        public string Tel
        {
            get { return fTel; }
            set { SetPropertyValue<string>("Tel", ref fTel, value); }
        }
        string fEmail;
        [Size(50)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fSerial;
        [Size(255)]
        public string Serial
        {
            get { return fSerial; }
            set { SetPropertyValue<string>("Serial", ref fSerial, value); }
        }
        public User(Session session) : base(session) { }
        public User() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Emplacement : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        string fEmpName;
        [Size(50)]
        public string EmpName
        {
            get { return fEmpName; }
            set { SetPropertyValue<string>("EmpName", ref fEmpName, value); }
        }
        string fLastName;
        [Size(255)]
        public string LastName
        {
            get { return fLastName; }
            set { SetPropertyValue<string>("LastName", ref fLastName, value); }
        }
        string fFirstName;
        [Size(255)]
        public string FirstName
        {
            get { return fFirstName; }
            set { SetPropertyValue<string>("FirstName", ref fFirstName, value); }
        }
        string fEmpNo;
        [Size(50)]
        public string EmpNo
        {
            get { return fEmpNo; }
            set { SetPropertyValue<string>("EmpNo", ref fEmpNo, value); }
        }
        string fColor;
        [Size(255)]
        public string Color
        {
            get { return fColor; }
            set { SetPropertyValue<string>("Color", ref fColor, value); }
        }
        string fPhone;
        [Size(255)]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fEmail;
        [Size(255)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fPosition;
        [Size(1073741823)]
        public string Position
        {
            get { return fPosition; }
            set { SetPropertyValue<string>("Position", ref fPosition, value); }
        }
        string fTransmissAutomatic;
        [Size(3)]
        public string TransmissAutomatic
        {
            get { return fTransmissAutomatic; }
            set { SetPropertyValue<string>("TransmissAutomatic", ref fTransmissAutomatic, value); }
        }
        short fMPG_City;
        public short MPG_City
        {
            get { return fMPG_City; }
            set { SetPropertyValue<short>("MPG_City", ref fMPG_City, value); }
        }
        DateTime fSundayAvailSt;
        public DateTime SundayAvailSt
        {
            get { return fSundayAvailSt; }
            set { SetPropertyValue<DateTime>("SundayAvailSt", ref fSundayAvailSt, value); }
        }
        DateTime fMondayAvailSt;
        public DateTime MondayAvailSt
        {
            get { return fMondayAvailSt; }
            set { SetPropertyValue<DateTime>("MondayAvailSt", ref fMondayAvailSt, value); }
        }
        DateTime fTuesdayAvailSt;
        public DateTime TuesdayAvailSt
        {
            get { return fTuesdayAvailSt; }
            set { SetPropertyValue<DateTime>("TuesdayAvailSt", ref fTuesdayAvailSt, value); }
        }
        DateTime fWednesdayAvailSt;
        public DateTime WednesdayAvailSt
        {
            get { return fWednesdayAvailSt; }
            set { SetPropertyValue<DateTime>("WednesdayAvailSt", ref fWednesdayAvailSt, value); }
        }
        DateTime fThursdayAvailSt;
        public DateTime ThursdayAvailSt
        {
            get { return fThursdayAvailSt; }
            set { SetPropertyValue<DateTime>("ThursdayAvailSt", ref fThursdayAvailSt, value); }
        }
        DateTime fFridayAvailSt;
        public DateTime FridayAvailSt
        {
            get { return fFridayAvailSt; }
            set { SetPropertyValue<DateTime>("FridayAvailSt", ref fFridayAvailSt, value); }
        }
        DateTime fSaturdayAvailSt;
        public DateTime SaturdayAvailSt
        {
            get { return fSaturdayAvailSt; }
            set { SetPropertyValue<DateTime>("SaturdayAvailSt", ref fSaturdayAvailSt, value); }
        }
        DateTime fSundayAvailEnd;
        public DateTime SundayAvailEnd
        {
            get { return fSundayAvailEnd; }
            set { SetPropertyValue<DateTime>("SundayAvailEnd", ref fSundayAvailEnd, value); }
        }
        DateTime fMondayAvailEnd;
        public DateTime MondayAvailEnd
        {
            get { return fMondayAvailEnd; }
            set { SetPropertyValue<DateTime>("MondayAvailEnd", ref fMondayAvailEnd, value); }
        }
        DateTime fTuesdayAvailEnd;
        public DateTime TuesdayAvailEnd
        {
            get { return fTuesdayAvailEnd; }
            set { SetPropertyValue<DateTime>("TuesdayAvailEnd", ref fTuesdayAvailEnd, value); }
        }
        DateTime fWednesdayAvailEnd;
        public DateTime WednesdayAvailEnd
        {
            get { return fWednesdayAvailEnd; }
            set { SetPropertyValue<DateTime>("WednesdayAvailEnd", ref fWednesdayAvailEnd, value); }
        }
        DateTime fThursdayAvailEnd;
        public DateTime ThursdayAvailEnd
        {
            get { return fThursdayAvailEnd; }
            set { SetPropertyValue<DateTime>("ThursdayAvailEnd", ref fThursdayAvailEnd, value); }
        }
        DateTime fFridayAvailEnd;
        public DateTime FridayAvailEnd
        {
            get { return fFridayAvailEnd; }
            set { SetPropertyValue<DateTime>("FridayAvailEnd", ref fFridayAvailEnd, value); }
        }
        DateTime fSaturdayAvailEnd;
        public DateTime SaturdayAvailEnd
        {
            get { return fSaturdayAvailEnd; }
            set { SetPropertyValue<DateTime>("SaturdayAvailEnd", ref fSaturdayAvailEnd, value); }
        }
        short fMPG_Highway;
        public short MPG_Highway
        {
            get { return fMPG_Highway; }
            set { SetPropertyValue<short>("MPG_Highway", ref fMPG_Highway, value); }
        }
        string fCategory;
        [Size(7)]
        public string Category
        {
            get { return fCategory; }
            set { SetPropertyValue<string>("Category", ref fCategory, value); }
        }
        string fDescription;
        [Size(1073741823)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fHyperlink;
        [Size(50)]
        public string Hyperlink
        {
            get { return fHyperlink; }
            set { SetPropertyValue<string>("Hyperlink", ref fHyperlink, value); }
        }
        byte[] fPicture;
        public byte[] Picture
        {
            get { return fPicture; }
            set { SetPropertyValue<byte[]>("Picture", ref fPicture, value); }
        }
        decimal fPrice;
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>("Price", ref fPrice, value); }
        }
        string fRtfContent;
        [Size(1073741823)]
        public string RtfContent
        {
            get { return fRtfContent; }
            set { SetPropertyValue<string>("RtfContent", ref fRtfContent, value); }
        }
        byte[] fPhoto;
        public byte[] Photo
        {
            get { return fPhoto; }
            set { SetPropertyValue<byte[]>("Photo", ref fPhoto, value); }
        }
        byte[] fImage;
        public byte[] Image
        {
            get { return fImage; }
            set { SetPropertyValue<byte[]>("Image", ref fImage, value); }
        }
        public Emplacement(Session session) : base(session) { }
        public Emplacement() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
