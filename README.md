# Book Lending Library API Coding Challenge

## Introduction

Welcome to the Book Lending Library API coding challenge! In this challenge, we will be creating a simple API for a book lending library. The primary focus is on implementing core functionalities without the need for a user interface.  We'll be pairing on this challenge.

## Instructions
 - Check out this repository locally
 - Create a new branch for your work
 - Familiarise yourself with the code
 - We'll be working on your machine doing a screenshare

## Migrations
dotnet ef migrations add "Initial Migration" -p ./LendingLibraryInterview.Data -s ./LendingLibraryInterview.Api

## Notes for Cera staff:
https://ceracare.atlassian.net/wiki/x/AYCos

## Candidate Notes
Things done differently:

In hindsight I would have left the data and migrations alone and focused on the coding. I assumed it would be a few minutes and that way I could run the program once the first endpoint was done and see some results before moving on to complete the exercise, knowing that I have something that works.

What I would do next: 

Create the 2 endpoints SearchBooksByTitleAsync and SearchBooksByIsbnAsync, then hanle the error responses for any invalid search queries, as these were what was requested in the requirements provided. 

Next I would create all the unit tests for the controller and service and ensure I have sufficient code coverage. I could also use Theories or inline data instead of Facts.

Once all tests passed, I would then move on to getting the migration to work and the local database up and running so I could hit the swagger endpoints and get data back.

After that I could look at things like performance and refactoring the code, if necessary.
