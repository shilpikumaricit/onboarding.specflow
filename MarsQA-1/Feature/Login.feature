﻿Feature: AddSellerProfile
	As I am a skilled Seller
	I would like to add profile details
	So that people seeking for skills can look into my profile

@Positive
Scenario: Add profile description details
	Given Seller login to mars application as seller
	And Seller navigate to profile page
	When Seller click on description edit button
	Then Seller should be able to add the description to the profile

@Negative
Scenario: Add empty data in description field
  Given I login to mars application as seller
  And  seller navigate to profile page
  When seller click on description edit button
  And  try to add empty data in description box
  Then Seller should not able to add empty data
  Examples: 
  | Description |
  |             |

  @Positive
  Scenario: Add New Language in language field
  Given I loging to mars application as seller
  And Seller navigate to the profile page
  When Seller click on language butten
  Then Click on add new button 
  Then Add a language in add language field
  And Select a level from choose lenguage level
  And click on add butten
  Then seller should able to add language succesfully
  
  @Negative
  Scenario: Add language without selecting dropdown
  Given As seller loging to mars application 
  And seller navigate to the profile page
  And Try to add language in add language field without selecting dropdown
  Then Seller should not able to add language
  
  
  @Negative
  Scenario: Add Duplicate language
  Given As seller loging to mars application
  And seller navigate to the profile page
  When Seller should try to add duplicate language
  Then Seller should not able to add language
  
  @Negative
  Scenario: Add Null value in Language field
  Given As seller loging to mars application
  And seller navigate to the profile page
  When Seller should try to add null valu in language field 
  Then Seller should not able to add language
  
  @Validate
  Scenario: Verify the add language
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should click on language button
   Then Seller should be able to see the add language

@Update
 Scenario: Update the language
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should click on language button
   And Seller click on edit button edit the language
   And click on update butten
   Then Seller should be able to update the language
   @Delete
   Scenario: Delete the language
	Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on language buttona
	And click on Delete or Corres button
	Then Seller should be able to delete the language from list
	Then Seller should be able to delete the language from list
 @Psitive
 Scenario: Add New skill 
   Given Seller loging to mars application as seller
   And Seller navigate to the profile page
   When Seller click on skill butten
   Then Click on add new button 
   Then Add a skill in add skill field
   And Select a level from choose skill level
   And click on add butten
   Then seller should able to add skill succesfully
 @Negative
Scenario: Add skill without selecting dropdown
   Given As seller loging to mars application 
   And seller navigate to the profile page
   And Try to add skill in add skill field without selecting dropdown
   Then Seller should not able to add skill
@Negative
Scenario: Add Null value in skill field
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should try to add null valu in skill field 
   Then Seller should not able to add skill 
 @Duplicate
 Scenario: Add Duplicate skill
  Given As seller loging to mars application
  And seller navigate to the profile page
  When Seller should try to add duplicate skill
  Then Seller should not able to add skill
  @Verify
  Scenario: Verify the add skill
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should click on skill button
   Then Seller should be able to see the add skill
   @update
   Scenario: Update the skill
    Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on skill button
    And Seller click on edit button for edit the skill
    And click on update butten
    Then Seller should be able to update the skill
	@Delete
	Scenario: Delete the skill
	Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on skill buttona
	And click on Delete or Corres button
	Then Seller should be able to delete the skill from list
	@Positive
Scenario: Add New Education
   Given Seller loging to mars application as seller
   And Seller navigate to the profile page
   When Seller click on Education butten
   And Click on add new button 
   Then Add a college/University in add college/University field
   And Select a cuntry from country of college/university
   And select a Title from title dropdown
   Then Add Degree in degree field
   And select a Year from Year fo graduat dropdown
   And click on add butten
   Then seller should able to add education succesfully
@Negative
   Scenario: Add Education without selecting dropdown
   Given As seller loging to mars application 
   And seller navigate to the profile page
   And Try to add education  without selecting dropdown
   Then Seller should not able to add education
 @Negative
 Scenario: Add Null value in Education field
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should try to add null valu in Educationl field 
   Then Seller should not able to add education
 @Negative
Scenario: Add Duplicate Education
  Given As seller loging to mars application
  And seller navigate to the profile page
  When Seller should try to add duplicate education
  Then Seller should not able to add education
  @verify
  Scenario: Verify the add Education
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should click on Education button
   Then Seller should be able to see the add education
   @update 
   Scenario: Update the Education
    Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on education button
    And Seller click on edit button for edit the education
    And click on update butten
    Then Seller should be able to update the education
	@Delete
	Scenario: Delete the Education
	Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on education buttona
	And click on Delete or Corres button
	Then Seller should be able to delete the education from list
	@Positive
	Scenario: Add New certification
   Given Seller loging to mars application as seller
   And Seller navigate to the profile page
   When Seller click on certification butten
   Then Click on add new button 
   Then Add a certificat/reward in certificat/reward field
   And Select a year from choose year dropdown
   And click on add butten
   Then seller should able to add certificate succesfull 
   @Negative
   Scenario: Add certificate without selecting dropdown
   Given As seller loging to mars application 
   And seller navigate to the profile page
   And Try to add certificate  without selecting dropdown
   Then Seller should not able to add certificate
   @Negative
   Scenario: Add Null value in certification field
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should try to add null valu incertification field 
   Then Seller should not able to add certification
   @Negative
   Scenario: Add Duplicate certification
  Given As seller loging to mars application
  And seller navigate to the profile page
  When Seller should try to add duplicate certification
  Then Seller should not able to add certification
  @verify
  Scenario: Verify the add certificate
   Given As seller loging to mars application
   And seller navigate to the profile page
   When Seller should click on certificate button
   Then Seller should be able to see the add certificate
   @update
   Scenario: Update the certificate
    Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on certificate button
    And Seller click on edit button for edit the certificate
    And click on update butten
    Then Seller should be able to update the certificate
	@delete
	Scenario: Delete the certificate
	Given As seller loging to mars application
    And seller navigate to the profile page
    When Seller should click on certificate button
	And click on Delete or Corres button
	Then Seller should be able to delete the certificate from list
	