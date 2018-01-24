Feature: Search API
    In order to search
    As an API Consumer
    I want the API to return appropriate http response codes

Scenario: Valid search request
    Given I search for red items
    When the response is received
    Then I will receive OK response

Scenario: Search with missing search term
    Given I search without search term
    When the response is received
    Then I will receive BadRequest response


Scenario: Validate the alternate search term and spell check result
    Given I search for "nik carps" items
    When the response is received
    Then I should see the alternate search term displayed
    And the spell check is true