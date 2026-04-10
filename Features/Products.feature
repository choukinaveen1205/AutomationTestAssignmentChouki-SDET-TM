Feature: Product Search

Scenario: Search valid product
    Given User is on home page
    When User searches for a valid product
    Then Product should be displayed

Scenario: Search invalid product
    Given User is on home page
    When User searches for an invalid product
    Then No product message should be displayed