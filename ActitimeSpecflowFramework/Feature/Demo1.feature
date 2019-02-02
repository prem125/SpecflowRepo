Feature:Demo1

Scenario: Verify Google Page
Given open the browser
When Enter the Url
Then Verify Title of Google Page

Scenario: Verify Google Page Search Box
Given open the browser
When Enter the Url
And Enter the Text in Search box
And Click on Search button
Then Verify the Text
