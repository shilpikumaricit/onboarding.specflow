﻿Feature: AddSellerProfile
	As I am a skilled Seller
	I would like to add profile details
	So that people seeking for skills can look into my profile

@Positive
Scenario: 1 Add new Language
	#Given As a Seller I will login to Mars App and navigate to profile page
	When Seller click on new Add Language  button
	Then Seller should be able to add the language to the profile page
	And should be able to verify the add language

@Positive
Scenario: 2 Edit existing Language
	#Given As a Seller I will login to Mars App and navigate to profile page
	When Seller click on edit Language  button
	Then Seller should be able to edit the language to the profile page
	And should be able to verify the edited language

@Positive
Scenario: 3 Delete existing Language
	#Given As a Seller I will login to Mars App and navigate to profile page
	When Seller click on delete Language  button
	Then Seller should be able to delete the language to the profile page
	And should be able to verify the deleted language

@Psitive
 Scenario:4 Add New skill 
   #Given Seller loging to mars application as seller
   #And Seller navigate to the profile page
   When Seller click on skill button
   Then Click on add new button 
   Then Add a skill in add skill field and Select a level from choose skill level
   Then click on add button seller should able to add/verify skill succesfully
    
@Positive
Scenario: 5 Edit existing Skill
	#Given As a Seller I will login to Mars App and navigate to profile page
	When Seller click on edit skill  button
	Then Seller should be able to edit the skill to the profile page
	And should be able to verify the edited skill
	@Positive
Scenario: 6 Delete existing Skill
	#Given As a Seller I will login to Mars App and navigate to profile page
	When Seller click on delete Skill  button
	Then Seller should be able to delete the Skill to the profile page
	And should be able to verify the deleted Skill

Scenario: 7 Add Eduction
When seller click on Education Tab And Click on Add new Button
Then Seller should be able to fill his eduction and Verify it.

Scenario: 8 Edit Eduction
When seller click on Education Tab And Click on Edit existing education Button
Then Seller should be able to Edit his eduction and Verify it.

Scenario: 9 Delete Eduction
When seller click on Education Tab And Click on Delete existing education Button
Then Seller should be able to Delete his eduction and Verify it.