Feature: Registration

Scenario: Successful Registration
    Given User navigates to registration page
    When User enters valid registration details
    And User submits registration form
    Then Account should be created successfully

Scenario: Registration with empty fields
    Given User navigates to registration page
    When User submits empty registration form
    Then Registration error messages should be displayed