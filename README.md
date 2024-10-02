# CefSharpIssue

This repository reproduces an issue where a form submittion containing specifically named inputs, causes the CefSharp browser to crash.

This only occurs when using the Chrome Bootstrap and setting a value for the CefSettings.Locale property.

## Steps to Reproduce
- Open CefSharpIssue.sln

- Configure the solution to start both projects Browser and WebApp

- Run the solution

- The browser WinForms app should launch and navigate to a very basic form with 3 unlabelled inputs and a Save button. Type a dot into each input then click the Save button

**Expected**
The form submits

**Actual**
The browser crashes