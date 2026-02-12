I kan ikke pushe direkte til main — lav en ny branch, push jeres ændringer dertil og lav en pull request for at merge til main. Hvis testen fejler, kan I ikke merge. 👍

Når I opretter branch-regler i GitHub, skal I gå til Settings → Branches → Branch protection rules, vælge reglen Status check og sætte den til at bruge den tilhørende GitHub Action — i dette projekt “Build & Test (Navnet er oprettet i Yaml)” — så vi sikrer, at builds og tests kører automatisk.

Feature Ma dude
Create and Manage Tickets: Admin users can add tickets with start and end dates and assign them to specific event sections.
Place Orders: Users can select tickets from multiple sections. TicketJam validates ticket availability and inventory before completing the order.
Inventory Management: The system enforces minimum inventory levels and blocks simultaneous purchases of the last available ticket by multiple users.
