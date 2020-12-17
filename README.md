# Pemanfaatan Event Handler untuk Observer Pattern

Observer pattern merupakan behavioral pattern. pattern yang fokus pada interaksi antar objek untuk mencapai sesuatu yang lebih baik.

Mengobservasi perubahan nilai dari objek lain. ketika state pada objek itu berubah maka akan memberitahu pada obyek yang mensubscribe objek tersebut.

## SCOPE & FUNCTIONALITIES
- Belajar memanfaatkan fitur .NET EventHandler untuk menangkap sinyal yang di trigger dari tempat lain. 
- Dapat merangkai beberapa object class seolah-olah saling berhubungan melalui Event (sinyal).

## HOW DOES IT WORKS?

Diawali dengan method pada class MainWindow.xaml.cs
```csharp
    public partial class MainWindow : Window, VerificationResponse
    {
        MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindowController();
            controller.SubcribeVerificationResult(this);

        }
``` 19.11.2821

logikanya terdapat pada class `EmailVerification.cs`
``` csharp
    class EmailVerification
    {
        public event EventHandler emailVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {
            emailVerificationEvent(this, EventArgs.Empty);

        }
    }
``` 19.11.2821