```
PortfolioMVC/
│
├── Areas/
│   └── Admin/
│       ├── Controllers/
│       │   ├── AdminDashboardController.cs
│       │   ├── ProjectsController.cs
│       │   ├── BlogController.cs
│       │   └── ContactMessagesController.cs
│       │
│       ├── Views/
│       │   ├── AdminDashboard/
│       │   │   └── Index.cshtml
│       │   ├── Projects/
│       │   │   ├── Index.cshtml
│       │   │   ├── Create.cshtml
│       │   │   ├── Edit.cshtml
│       │   │   └── Delete.cshtml
│       │   ├── Blog/
│       │   │   ├── Index.cshtml
│       │   │   ├── Create.cshtml
│       │   │   ├── Edit.cshtml
│       │   │   └── Delete.cshtml
│       │   └── ContactMessages/
│       │       └── Index.cshtml
│       │
│       └── Views/Shared/
│           └── _AdminLayout.cshtml
│
├── Controllers/
│   ├── HomeController.cs
│   ├── ProjectsController.cs
│   ├── BlogController.cs
│   └── ContactController.cs
│
├── Models/
│   ├── Project.cs
│   ├── BlogPost.cs
│   └── ContactMessage.cs
│
├── Views/
│   ├── Home/
│   ├── Projects/
│   ├── Blog/
│   ├── Contact/
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _Navbar.cshtml
│       └── _Footer.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── tailwind.config.js
├── postcss.config.js
├── package.json
├── PortfolioMVC.csproj
└── Program.cs

```