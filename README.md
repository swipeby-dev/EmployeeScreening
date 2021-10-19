# Swipeby  Developer Screening Test
## Overview
A Junior Dev. was tasked to create an ASP .NET Core web service with a single GET endpoint.  This repository represents his submitted code.  While it does work, upon a closer review by an outside consultant it was deemed a substandard implementation.  Your objective is to refactor his code in anyway you'd like to make it "Enterprise Grade".

## Original Objectives
The original objectives of the project:  
* Create a GET endpoint with the signature: `/api/localweather/{id}`
* The `id` is a v4 GUID that is to be looked up from the database's `users` table.
* It will return two columns, `latitude` and `longitude`, that should then be used to return the results of an external weather api endpoint.
* The endpoint, `https://api.weather.gov/points/{lat},{lon}`, is detailed here: https://weather-gov.github.io/api/general-faqs

## Your Objective
You have been contracted as an expert in your field.  You accept nothing less than professionally written enterprise-grade code.  Your objectives:  
* Perform a thorough code review and be able to discuss any issues you find.
* Correct any issues you may have with the codebase, showing that you were the right person for the job.
* Note the reasons behind your changes and any new patterns you are putting in place.

**It is that simple!**

This refactor can take as little or as long as you would like.  Try to keep it under 1 hour.  Fork this repository into a private Github repo that you control, create a new branch, make your changes, and then let us know when you are done.  When you are done, make sure to give `swipeby-dev` access to your private repo.

## Thank you - *The Swipeby Dev Team*