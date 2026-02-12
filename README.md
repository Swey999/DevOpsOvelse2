I kan ikke pushe direkte til main — lav en ny branch, push jeres ændringer dertil og lav en pull request for at merge til main. Hvis testen fejler, kan I ikke merge. 👍

Når I opretter branch-regler i GitHub, skal I gå til Settings → Branches → Branch protection rules, vælge reglen Status check og sætte den til at bruge den tilhørende GitHub Action — i dette projekt “Build & Test (Navnet er oprettet i Yaml)” — så vi sikrer, at builds og tests kører automatisk.

Best features on UCN
