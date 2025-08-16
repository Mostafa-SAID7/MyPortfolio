```
PortfolioMVC/
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
│   │   └── Index.cshtml
│   ├── Projects/
│   │   └── Index.cshtml
│   ├── Blog/
│   │   └── Index.cshtml
│   ├── Contact/
│   │   └── Index.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _Navbar.cshtml
│       └── _Footer.cshtml
│
├── wwwroot/
│   ├── css/
│   │   ├── site.css        (your tailwind input file)
│   │   └── output.css      (generated tailwind build)
│   ├── js/
│   │   └── site.js
│   └── images/
│       └── (project images, profile picture etc.)
│
├── tailwind.config.js
├── postcss.config.js
├── package.json
├── PortfolioMVC.csproj
└── Program.cs / Startup.cs   (depending on .NET version)
```