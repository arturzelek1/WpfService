# 🖥️ WPF Shop 

**WPF Shop** is a desktop application developed using Windows Presentation Foundation (WPF) in C#. It provides a user-friendly interface to interact with a Windows Service, allowing users to start, stop, and monitor the service's status seamlessly.

---

## 🎯 Purpose

This project demonstrates the integration of a WPF client application with a Windows Service, highlighting skills in inter-process communication, service management, and responsive UI design. It serves as a practical example of managing background processes through a graphical interface.

---

## 🛠️ Technologies Used

- **Frontend**: WPF (Windows Presentation Foundation), XAML  
- **Backend**: C# (.NET Framework)  
- **Service Management**: System.ServiceProcess namespace  
- **Development Tools**: Visual Studio

---

## 🚀 Getting Started

### Prerequisites

- Windows operating system  
- .NET Framework installed  
- Visual Studio with WPF and Windows Service development capabilities

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/arturzelek1/WPF_Shop.git
   cd WPF_Shop
2. **Open the solution in Visual Studio:**
- Launch Visual Studio.
- Open the .sln file.
3. **Build the solution:**
- Restore any necessary NuGet packages.
- Build the solution to ensure all dependencies are correctly configured.
4. **Run the application:**
- Start the WPF application.

---

## 📁 Project Structure

```plain text
WpfService/
├── WpfService/              # Main WPF application
│   ├── MainWindow.xaml      # UI layout
│   ├── MainWindow.xaml.cs   # UI logic and event handling
│   └── App.xaml             # Application configuration
├── WpfService.sln           # Visual Studio solution file
└── README.md                # Project documentation
```

---

## 📄 License

This project is licensed under the MIT License.
