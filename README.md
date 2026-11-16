\# ApiDemo - Web APIs \& Fetch



\## Project Description



ApiDemo is an ASP.NET Core Razor Pages application that demonstrates how to create Web API endpoints and retrieve data using JavaScript Fetch.



\## Features



\- GET API endpoint that returns all blog posts as JSON.

\- POST API endpoint that adds new blog posts.

\- Model validation requiring a title and content.

\- Dashboard that uses JavaScript Fetch to retrieve posts.

\- Displays the total number of blog posts.

\- Displays recent blog post titles dynamically.



\## Technologies Used



\- C#

\- ASP.NET Core

\- Razor Pages

\- Web API

\- JavaScript Fetch

\- HTML and CSS



\## API Endpoints



| Method | Endpoint | Description |

|---|---|---|

| GET | /api/posts | Returns all posts |

| POST | /api/posts | Creates a new post |



\## Dashboard



The dashboard retrieves posts from the API and displays the total post count and recent post titles.



\### Dashboard Screenshot



!\[ApiDemo Dashboard](Dashboard.png)



\## How to Run



1\. Clone or download this repository.

2\. Open PowerShell in the project folder.

3\. Run `dotnet restore`.

4\. Run `dotnet run`.

5\. Open the local URL displayed in the terminal.

6\. Visit `/Dashboard` to view the dashboard.

7\. Visit `/api/posts` to view the JSON API response.



\## Testing



The GET endpoint was tested successfully.



The POST endpoint was tested successfully by creating a new blog post.



Model validation was tested by submitting an empty title and content, which returned a Bad Request response.



\## Author



Student Web Development Assignment - Module 12.3



