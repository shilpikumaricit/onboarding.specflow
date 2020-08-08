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
 Scenario: Add New skill 
   #Given Seller loging to mars application as seller
   #And Seller navigate to the profile page
   When Seller click on skill button
   Then Click on add new button 
   Then Add a skill in add skill field and Select a level from choose skill level
   Then click on add button seller should able to add skill succesfully