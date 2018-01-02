# .asp-net-core---PickMeUp-Part-1

## About PickMeUp Project
PickMeUp is an application where user choose their pickup point and destination. The addresses comes from a third-party API.


## Overview
This repo is a part 1 of X repos. 

## This repo covers
* Call API Async during startup
* Store API result inMemory
* Present API result in RazorView


## Installation
1. Register for an API Key on : https://www.trafiklab.se/api/sl-hallplatser-och-linjer-2
2. Download repo
3. add "appsettings.json" in PickMeUp\PickMeUp
```
{
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "StopApiKey": "xxxxxxxxxxxxxxxxxxxxxxx"
}
```
4. Run application locally on your machine.

## Sources for howto and understanding

https://app.pluralsight.com/library/courses/aspdotnet-core-fundamentals/table-of-contents