**CSE 212 – Programming with Data Structures**

**W05 Prove – Response Document**

------------------------------------------

_It is a violation of BYU-Idaho Honor Code to post or share this document with others or to post it online.  Storage into a personal and private repository (e.g. private GitHub repository, unshared Google Drive folder) is acceptable._

------------------------------------------

**Question 1:**  From Part 1, how did you answer the interview question for the Set Operations problem (should be no more than 30 seconds if spoken aloud)?

To find an intersection, I would create a for loop that iterates through the items of one of the sets, and call the Contains() operator on the second set, adding it to the returned set if the item is contained.
To find a union, I would copy the second set, and loop through the items of the first set, using checking with Contains() if the item already is in the set, using Add() to add the items if not found to the returned set.
Sets are useful for storing and recalling unique data points. They contain unique values (no duplicates), quick access to data, and are easily compared to other sets. The set doesn't necessarily keep items in order, additionally the set must increase in size to avoid conflicts in order to keep data access quick.

**Question 2:**  From Part 2, how did you answer the interview question for the Find Pairs problem (should be no more than 30 seconds if spoken aloud)?

I would store the set, use a for loop to iterate each value, reverse their order, and use Contains() to see if the item exists. After checking if the reversed string exists, I would remove the original string and found pair if applicable to prevent duplicate additions, adding the pair to the returned set if found.

------------------------------------------

_Remember:  Make sure all of your changes are committed and pushed to the `main` branch of your_ **prove-05-[username]** _repository_

_Also, submit this document and a link to your repository in I-Learn_
