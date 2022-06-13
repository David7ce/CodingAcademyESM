# Git tutorial

## Pre-isntallation
- Requirements:
    - Install Git on your machine:
        - On Linux `sudo dnf install git-all`.
        - On mac trying `git --version`.
        - On Windows download an execute the [.exe](https://github.com/git-for-windows/git/releases/) or run `choco install git´with the chocolatey package.
    - Create a GitHub account
- Upload to GitHub:
    1. Verify your GitHub account (external login or OATH token):
        - Installing and executing [GitHub CLI](https://github.com/cli/cli#installation) or [GitHub Credential Manager](https://github.com/GitCredentialManager/git-credential-manager)
    2. Use
        - With commands from terminal.
        - With graphic interface from your IDE (VSCode / VSCodium) activate "git enable" on settings
        - With external apps like Git clients with graphical interface like (Gitkraken, GitHub Desktop, Sublime Merge...).

## Git commands, use on terminal
1.  Open a directory with content (folder with files inside)
2.  Initialize Git
```bash
git init
```
3.  Create content inside
```bash
mkdir myproject
cd myproject
```
4.  Files in your Git repository folder can be in one of 2 states:
-   Tracked. Stored on the repository.
-   Untracked (U). Only in local not in the repository. To track them you need to stage them or add them to the staging environment.
```bash
git add index.html  # using `--all` will `stage` all changes (new, modified, and deleted) files
```
5.  Git Commit
```bash
git commit -m "First release." # with -a  (commit without stage)
```
6.  Git Push
```bash
git push <remote><branch>
```
7.  Git Pull (fetch + merge)
```bash
git fetch origin
git merge origin/master
git pull origin
```

## Git, use on the IDE (VSCode)
1. Open a folder.
2. Source control menu and start repository.
    - Files with U (Untracked).
    - Upload content to the repository: commit & push
        1. Add link of the repository (command palette or ctrl+shift+P).
        2. Select "Commit": write a description and check the mark.
        3. Push the changes to the repository.
    - Clone repository
        - Select "clone repository" and add the link.

