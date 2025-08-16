document.addEventListener("DOMContentLoaded", () => {
    const menuToggle = document.getElementById("menuToggle");
    const mobileMenu = document.getElementById("mobileMenu");
    const darkModeToggle = document.getElementById("darkModeToggle");
    const sunIcon = document.getElementById("sunIcon");
    const moonIcon = document.getElementById("moonIcon");

    // ✅ Mobile menu toggle
    if (menuToggle && mobileMenu) {
        menuToggle.addEventListener("click", () => {
            mobileMenu.classList.toggle("hidden");
        });
    }

    // ✅ Load dark mode preference
    if (
        localStorage.getItem("theme") === "dark" ||
        (!localStorage.getItem("theme") && window.matchMedia("(prefers-color-scheme: dark)").matches)
    ) {
        document.documentElement.classList.add("dark");
        if (sunIcon && moonIcon) {
            sunIcon.classList.remove("hidden");
            moonIcon.classList.add("hidden");
        }
    } else {
        document.documentElement.classList.remove("dark");
        if (sunIcon && moonIcon) {
            sunIcon.classList.add("hidden");
            moonIcon.classList.remove("hidden");
        }
    }

    // ✅ Toggle dark mode
    if (darkModeToggle) {
        darkModeToggle.addEventListener("click", () => {
            document.documentElement.classList.toggle("dark");

            if (document.documentElement.classList.contains("dark")) {
                localStorage.setItem("theme", "dark");
                if (sunIcon && moonIcon) {
                    sunIcon.classList.remove("hidden");
                    moonIcon.classList.add("hidden");
                }
            } else {
                localStorage.setItem("theme", "light");
                if (sunIcon && moonIcon) {
                    sunIcon.classList.add("hidden");
                    moonIcon.classList.remove("hidden");
                }
            }
        });
    }

    // ✅ Smooth scroll for anchor links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener("click", function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute("href"));
            if (target) {
                target.scrollIntoView({ behavior: "smooth" });
            }
        });
    });
});
document.addEventListener("scroll", () => {
    const navbar = document.getElementById("mainNavbar");
    if (window.scrollY > 20) {
        navbar.classList.add("shadow-md", "backdrop-blur-md");
    } else {
        navbar.classList.remove("shadow-md", "backdrop-blur-md");
    }
});
document.addEventListener("DOMContentLoaded", () => {
    const links = document.querySelectorAll("#mainNavbar a");
    const currentPath = window.location.pathname;

    links.forEach(link => {
        if (link.getAttribute("href") === currentPath) {
            link.classList.add("text-blue-600", "dark:text-blue-400", "font-semibold");
        } else {
            link.classList.add("hover:text-blue-600", "dark:hover:text-blue-400");
        }
    });
});

