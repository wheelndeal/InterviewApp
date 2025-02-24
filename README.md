# Directions
## C#
- Add a extra string field to the Question model called Hint
- Add a hint to each question object in GetQuestions, this is located in the HomeController (This can be anything)
## JavaScript/Knockout
- Fix the bug in the QuestionModel function, this is causing the questions to not display on the screen
- Add a observable for the Hint field to QuestionModel
## CSHTML/Knockout
- data bind the value of hint to the title attribute of the span that displays the question text
- Add a span that displays the Answer text and hide it when showAnswer is false
- Add a button that thats shows the answer with text "Show Answer" and hides the answer with text "Hide Answer"
