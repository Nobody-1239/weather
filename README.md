# weather

## Introduction
weatherApp is a desktop application developed in C# using Windows Forms, designed to display weather information. This application utilizes a multi-layer architecture to ensure maintainable and scalable code.

## Features
Connect to weather data source: Retrieves weather information based on the city entered by the user.

Display weather information: Shows weather status, temperature, and wind speed.

Attractive UI: Uses images related to weather status for better user experience.

Modular design: Uses different layers for managing data and presentation logic.

## Project Structure
Business_Layer: Contains a class to manage and extract weather data.

Presentation_Layer: Acts as an intermediary between the business and UI layers to enhance data management and presentation logic.

UI_Layer: Contains the main form of the application and controls for displaying information.