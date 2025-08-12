# 🛡 Mitigating Shilling Attacks in E-Commerce

## 📌 Project Overview
Shilling attacks are malicious attempts to manipulate product ratings and reviews to mislead customers.  
This project aims to **detect and prevent** such attacks in an e-commerce environment, ensuring fair recommendations and trustworthy product information.

The system monitors user behavior, analyzes rating patterns, and flags suspicious activities to improve the reliability of the platform.

---

## 🛠 Technology Usage
| Technology | Usage |
|------------|-------:|
| CSS        | 48.5%  |
| ASP.NET    | 20.1%  |
| JavaScript | 16.5%  |
| HTML       | 13.0%  |
| C#         | 1.9%   |

---

## 🚀 Features
- User-friendly e-commerce interface  
- Secure user registration and login  
- Product listing with review and rating options  
- Detection and mitigation of suspicious rating patterns  
- Admin panel for monitoring flagged activities  

---


## ⚙️ Installation & Setup
1. **Clone this repository:**
git clone https://github.com/Sduthika28/shilling-attack-ecommerce.git
2. **Open the project in Visual Studio** (or your preferred IDE that supports ASP.NET and C#).  
3. **Restore NuGet packages** if prompted.  
4. **Set up the database**. 
5. **Run the project** using IIS Express or your configured server.  
6. **Access the application** in your browser:
http://localhost:xxxx
*(Replace `xxxx` with the port number shown when running the project.)*



---

## 📊 How It Works
1. **User Interaction Layer (HTML, CSS, JavaScript)**  
- Users browse products, leave reviews, and rate items through a responsive front-end interface.  
- JavaScript handles dynamic updates, form validation, and asynchronous data fetching via AJAX calls.

2. **Application Layer (ASP.NET, C#)**  
- ASP.NET controllers process incoming requests, manage user sessions, and route data between the UI and the database.  
- Review submissions are validated server-side to prevent injection or manipulation.

3. **Data Layer (SQL Server)**  
- Stores user profiles, products, reviews, and ratings.  
- Specialized queries analyze rating patterns, frequency, and deviation from norms.

4. **Shilling Attack Detection**  
- The system applies rule-based detection to identify abnormal rating patterns (e.g., repeated high/low ratings for specific items from the same user/IP).  
- Suspicious users or reviews are flagged for admin review.

5. **Admin Review Dashboard**  
- Admins can view flagged accounts, suspicious products, and related rating histories.  
- Option to remove fraudulent reviews or suspend malicious accounts.
---

## 📌 Future Enhancements
- Machine learning-based detection for higher accuracy  
- Email alerts for flagged accounts  
- Advanced data visualization for admin insights


