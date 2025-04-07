# Test 1 - ASP.NET MVC: Display URL Parameter Using Route

## ✅ Objective

Create an MVC Page such that the string value passed from the URL should be displayed on the web page.

### 📌 Example:

If the URL is:

http://localhost:61465/Employee/Mark

## 
Then the output should display:

![image](https://github.com/user-attachments/assets/35fbf1c5-2c44-47cc-898c-c6e5c6f34809)

# Test 2 - ASP.NET MVC ActionResult Demo

This project demonstrates various types of **Action Results** available in ASP.NET MVC, such as:

- `ContentResult`
- `FileContentResult`
- `FileStreamResult`
- `FilePathResult`
- `EmptyResult`
- `JavaScriptResult`
- `JsonResult`
- `RedirectResult`
- `RedirectToRouteResult`
- `HttpStatusCodeResult`
- `ViewResult`

---

## 📂 Project Structure
/Controllers └── DemoController.cs /Views └── /Demo ├── Index.cshtml ├── CustomView.cshtml 


---

## ▶️ How to Run

1. Open the solution in **Visual Studio**.
2. Make sure the following view files exist:
   - `Views/Demo/Index.cshtml`
   - `Views/Demo/CustomView.cshtml`
   - `Views/Demo/_PartialDemo.cshtml`
3. Press `F5` to run the app.
4. Navigate to:http://localhost:[port]/Demo/Index

   
---

## 📄 Demo Page

The `Index.cshtml` view provides links to all action methods. Each one demonstrates a different `ActionResult`.

### Example Links:

- `/Demo/ShowContent` → Returns plain text (`ContentResult`)
- `/Demo/ShowFile` → Returns downloadable file (`FileContentResult`)
- `/Demo/ShowFileStream` → Returns streamed file content (`FileStreamResult`)
- `/Demo/ShowFilePath` → Returns file from server path (`FilePathResult`)
- `/Demo/ShowEmpty` → Returns no content (`EmptyResult`)
- `/Demo/ShowJavaScript` → Runs JavaScript in browser (`JavaScriptResult`)
- `/Demo/ShowJson` → Returns JSON data (`JsonResult`)
- `/Demo/ShowRedirect` → Redirects to external URL (`RedirectResult`)
- `/Demo/ShowRedirectToRoute` → Redirects to Index (`RedirectToRouteResult`)
- `/Demo/ShowHttpStatus` → Returns custom status code (`HttpStatusCodeResult`)
- `/Demo/ShowView` → Loads a view (`ViewResult`)

---

## 🛠️ Notes

- Make sure `sample.txt` exists in `App_Data` for `ShowFilePath()` to work.
- `ShowView()` needs the file `CustomView.cshtml` in the `Views/Demo` folder.
- Use `JsonRequestBehavior.AllowGet` to enable GET for JSON actions.

---
# Final Output
![image](https://github.com/user-attachments/assets/385547c9-9d4e-4585-9103-8bef78ac2205)

## Content Result 
![image](https://github.com/user-attachments/assets/500ac77d-e9d9-4ae0-ac33-92e5f86eabd7)

## File Content Result 
![image](https://github.com/user-attachments/assets/3fbc3fe1-db79-4efc-bbb0-e765d7295e6e)

## Empty Result 
![image](https://github.com/user-attachments/assets/c2505556-915c-4fd6-bbc4-15fa6420b296)

## Javascript Result 
![image](https://github.com/user-attachments/assets/da5ee0b9-0b99-418f-bc3c-24152a3a10f9)

## JSON Result 
![image](https://github.com/user-attachments/assets/faa04a1d-2c9b-4c66-b502-779a67d906ac)

## Redirect Result
![image](https://github.com/user-attachments/assets/182a86a1-26d3-4ac8-b600-6e46d835b81b)

## HTTPStatusCode Result 
![image](https://github.com/user-attachments/assets/02e5e0c7-cafb-45a8-842e-e007058a4bde)

## View Result
![image](https://github.com/user-attachments/assets/fb2ee979-b0c8-404a-b387-71ce04da529b)

# Test 3 - OutputCache Demo - ASP.NET MVC

This project demonstrates the use of the `OutputCache` filter in an ASP.NET MVC application. The output of a controller action is cached for **5 minutes**, and the action returns the **current date and time** as a string.

## 🧪 Objective

Showcase how the `OutputCache` attribute can cache the result of an action method to improve performance and reduce server load.

## 🔧 Technologies Used

- ASP.NET MVC (.NET Framework)
- C#
- Razor Views (optional)
- Visual Studio

## 🚀 How It Works

The action method `Now()` in `HomeController` returns the current server time as a string. The `[OutputCache]` attribute caches this output for 5 minutes (300 seconds).

## The below ss is when i started my project along with system time
![image](https://github.com/user-attachments/assets/6c1e6eea-b49b-4ea7-9b6e-4889458089de) ![image](https://github.com/user-attachments/assets/02ae8572-b51e-45ac-b7be-2952f6cb7c9b)






















