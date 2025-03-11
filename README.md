# **AI Assistant Backend** 🧠🎙️  

An AI-powered full stack application for a **real-time voice assistant** that transcribes speech to text and responds with AI-generated messages. This project supports **user authentication** and **chat history storage**. Tech stack includes Next.js, TypeScript, .NET, HTML, and CSS.

# Note: In Progress 

## **Features**  
- **User Authentication**: Secure login and registration using JWT.  
- **Chat History Storage**: Save user messages and AI responses in a database.  
- **AI Responses**: Generate responses using OpenAI’s GPT-4.  

## **Setup Instructions**  

### **1️⃣ Prerequisites**  
- Install **.NET 7 or later**  
- Install the required NuGet packages:  
  ```bash
  dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
  dotnet add package OpenAI-API
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  ```

## Getting Started
Run the backend using:  
   ```bash
   dotnet run
   ```

Then, run the frontend using:

```bash
npm run dev
# or
yarn dev
# or
pnpm dev
# or
bun dev
```

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.
