Feature: Login Functionality

Scenario: Valid Login
    Given User navigates to login page
    When User enters valid username and password
    And Clicks on login button
    Then User should be logged in successfully

Scenario: Invalid Login
    Given User navigates to login page
    When User enters invalid username and password
    And Clicks on login button
    Then Login error message should be displayed