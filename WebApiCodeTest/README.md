Web Api Coding Test instructions
================================

Please complete the following tasks:

1. The first scenario "Valid search request" is currently failing.  Please refactor the test and get it to pass.
2. The second scenario "Search with missing search term" is incomplete.  Please complete the test and get it to pass.

(OPTIONAL) If you really like a challenge, try and complete the following:
3. A new spell-check feature has just been implemented on the Search API.  When a search term is typed incorrectly "Nik carps" instead of "Nike caps" the Search API will correct the mistake and return results for "Nike caps" and the response will include a flag to inform the consumer that the spell-check function has been used.
   Create a new feature file and add a scenario to test the new feature described above.

Notes/Hints
===========

- The solution was created in Visual Studio 2017 and targets .NET v4.6.1
- The solution is dependant on a few freely available open-source packages which can be restored from the NuGet package manager
- You are free to modify the framework as much or as little as you need, but we ask that you do not move the step definitions into different classes
- The solution is configured to run features in parallel, to reduce the total test execution time
- The tests are for the public ASOS Search API which is consumed when searching for products on http://asos.com