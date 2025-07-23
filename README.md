# SmartCommerce
SmartCommerce – A full-featured ASP.NET Core MVC e-commerce web application with support for product management, shopping cart, checkout, user roles, and admin control panel.
# SmartCommerce - Full-Stack E-commerce Application (.NET 9 MVC)

Welcome to **SmartCommerce**, a scalable and realistic e-commerce platform built with ASP.NET Core MVC (.NET 9), designed to sell both digital and physical products.  
This project aims to showcase professional-grade features such as role-based dashboards, product management, and order processing — perfect as a portfolio piece or assignment demonstrating practical enterprise software design.

---

## 🛠 Tech Stack

- ASP.NET Core MVC (.NET 9)  
- Entity Framework Core (ORM)  
- MS SQL Server (LocalDB or full)  
- ASP.NET Core Identity (Authentication & Authorization)  
- Bootstrap 5 (Frontend UI)  
- Visual Studio 2022 / VS Code / JetBrains Rider  

---

## 🎯 Project Vision & Domain

**A Digital & Physical Products Marketplace:**  

- Sell physical items with stock tracking  
- Sell digital downloads with secure access  
- Allow multiple categories for extensibility (books, music, courses, templates)  
- Realistic workflows like browsing products by category, managing a shopping cart, checkout, and role-based dashboards  

---

## 👥 User Roles & Dashboards

- **Admin**  
  Full control over products, categories, orders, users, and stock management  
- **Seller**  
  Manage their own product listings and view sales/orders  
- **Customer**  
  Browse catalog, add to cart, checkout, view order history and downloads  
- **Guest**  
  Browse products, register and login  

---

## 📁 Planned Pages & Features

- **Homepage**  
  [Add screenshot here]  
  Displays featured products, categories, and promotions.

- **Login / Registration**  
  [Add screenshot here]  
  User authentication with role selection for sellers/customers.

- **Product Listing**  
  [Add screenshot here]  
  Browse all products, filter by category, search by keyword.

- **Product Details**  
  [Add screenshot here]  
  View product info, images, price, stock status, download link (if digital).

- **Shopping Cart**  
  [Add screenshot here]  
  Review selected products, update quantities, remove items.

- **Checkout**  
  [Add screenshot here]  
  Enter shipping and payment details, review order summary.

- **Order Confirmation**  
  [Add screenshot here]  
  Show order number and summary after successful checkout.

- **Admin Dashboard**  
  [Add screenshot here]  
  Manage users, products, categories, view all orders.

- **Seller Dashboard**  
  [Add screenshot here]  
  Add/edit products, track own orders and sales statistics.

- **Customer Dashboard**  
  [Add screenshot here]  
  View past orders, download purchased digital products.

- **Category Management (Admin)**  
  [Add screenshot here]  
  Add/edit/remove product categories.

- **Order Management (Admin & Seller)**  
  [Add screenshot here]  
  View and update order statuses.

---

## 🗂 Core Database Entities

- **User** (extends IdentityUser)  
  Stores user info and roles.

- **Product**  
  - Name  
  - Description  
  - Price  
  - CategoryId  
  - IsDigital (bool)  
  - StockQuantity (nullable for digital products)  
  - ImageUrl  
  - DownloadUrl (for digital products)

- **Category**  
  - Name  
  - Description

- **CartItem**  
  - UserId  
  - ProductId  
  - Quantity

- **Order**  
  - UserId  
  - OrderDate  
  - TotalAmount

- **OrderItem**  
  - OrderId  
  - ProductId  
  - Quantity  
  - UnitPrice

- **Payment**  
  - OrderId  
  - PaymentMethod  
  - PaymentDate  
  - IsSuccessful

---

## 🚀 Step-by-Step Development Workflow & Plan

- **Project Initialization:**  
  Setup project, repo, folders, base layout, configure EF Core & Identity.

- **Core Models & Database:**  
  Build core entities: User, Product, Category, CartItem, Order, OrderItem, Payment.

- **Authentication & Authorization:**  
  Implement role-based login and registration (Admin, Seller, Customer).

- **Admin & Seller Dashboards:**  
  Build CRUD interfaces for products, categories, and orders.

- **Product Browsing & Details:**  
  Product listing with filters, product details page with add-to-cart.

- **Shopping Cart & Checkout:**  
  Cart management, order creation, order summary.

- **Order History & Management:**  
  Users view order history, admins/sellers manage orders.

- **Digital Product Delivery:**  
  Secure digital download links post-purchase.

- **Future Payment Integration:**  
  Implement Stripe or PayPal.

- **Additional Features:**  
  Product reviews, wishlists, notifications, analytics dashboard.

---

## 🔮 Future Enhancements & Roadmap

- Payment gateway integration (Stripe, PayPal)  
- Product reviews and ratings  
- Multiple shipping addresses per user  
- Email notifications for order status updates  
- Advanced search with filters and autocomplete  
- Analytics dashboards for sellers and admins  
- Wishlist and personalized product recommendations  
- Multi-language and localization support  
- Mobile responsiveness and Progressive Web App features  

---

## 🤝 Contributing

This is a solo academic/portfolio project by **Rukaiya**.  
Feel free to fork, experiment, and submit pull requests with improvements. Please keep commit messages clear and descriptive.

---

## 🙏 Thanks for checking out SmartCommerce!

If you find this project useful or inspiring, please ⭐ star the repo.  
Feedback and collaboration requests are always welcome!

---

## 📞 Connect

- GitHub: [https://github.com/Rukaiya2009](https://github.com/Rukaiya2009)  
- Email: rukaiyabinteshafique2009@gmail.com 
