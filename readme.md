# MailbirdFix

**MailbirdFix** is a simple application designed to fix the *"**Outdated Version**"* bug *(see image)* when installing updates of the Mailbird application.

![The older version of Mailbird cannot be removed.](https://images2.imgbox.com/3e/ff/x21tj6tx_o.png)

It performs the following tasks:

1. **Terminates Mailbird Processes**: The application checks if Mailbird is running and forcefully terminates the application to ensure the clean-up can proceed without interference.

2. **Cleans Up Registry Entries**: It deletes the registry keys associated with the "Mailbird" installer. This clean-up ensures that when re-opening the installer, it proceeds without errors.

3. **Completion Notification**: After successfully performing the clean-up, a notification displays to inform the user they can proceed with the Mailbird update without issues.

## Usage

To use **MailbirdFix**, follow these steps:

1. Download the Application: [MailbirdFix.exe](https://github.com/danielytuk/Mailbird-Installation-Fix/raw/main/MailbirdFix.exe)
2. Run the application with administrative privileges. *Administrative privileges are necessary to terminate processes and modify the registry.*
4. A completion notification will be displayed, indicating that it's safe to proceed with the Mailbird update.

## Disclaimer

This application is provided as-is and should be used at your own risk. Daniel, *and maintainers of this application* are not responsible for any potential issues that may arise as a result of using this tool.