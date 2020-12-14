This project will be responsible for creating/maintaining API that will provide future Frontend(s) with calendar information such as day, month, year, day type (workday, weekend, holiday, day off, vacation, meeting, event), Users Full Name etc.

As this project is still in planing mode important file so far is https://github.com/darkosubic/MyCalendar/blob/feature/MCL-1/MyCalendar_UML_Diagram.vsdx (Visio file with UML Diagrams)

Each day will have either workday or weekend status, and both statuses can be changed by admin.
Workdays can have multiple events:
Religious Holiday
Bank Holiday
Collective days off
Collective time off
Paid time off
Unpaid time off
Task
Meeting
Event
Flex time

Multiple events can occur at the same time and will be displayed next to each other.
If there are multiple events during the day they will be displayed one under another.
Admin can set on which day week starts and how long is work week.
Admin decides colour scheme for each status but users themselves can change these colours and revert back to defaults if needed.
Only logged in users can view Calendar.
User can be part of a team.
User can be part of multiple teams.
User can view only his and teams calendar entries.
Admin can view all calendar entries.
User can change or add only his Calendar entries.
Admin can change all calendar entries.
History of each calendar entry will be preserved and user who changed it must be logged.
Calendar can be set up to return data in week, month and year format.
If user no longer works for a company it will not be able to access calendar and will be disabled.
If disabled user tries to log into the system admin will be notified.
If user used to work for a company and again returns to the company he cannot add events during the time he did not work for the company.


Test data will be provided and README file will contain all test user login infos.


This project will be created and maintained using .Net 5, EF Core and SignalR and T-SQL.
