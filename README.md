# PersonalizationStoreRemover

PersonalizationStoreRemover is a tool that allow user to delete or archive the PersonalizationStore.xml file created by the Dynamics Nav's Windows client.

## Prerequisites

Before you begin, ensure you have met the following requirements:
 * You have a Windows computer, only Windows is supported
 * You have .Net Framework 4.5.2 or above on your machine
 * Optionnaly, you have administrator rights on the remote computer to access the C$ share

## Installing PersonalizationStoreRemover

To install PersonalizationStoreRemover, download a zip file from the latest release.
Unpack the file in a directory.

## Using PersonalizationStoreRemover

Launch the application by clicking on it. On application start, it will enumerate the local PersonalizationStore.xml files.
After that, you can connect to a remote computer by clicking the "Local / Remote" button and filling the textbox in the remote part.

In the file listing, you can see the list of user where a PersonalizationStore.xml file was found.
You have the choice between archiving or deleting the file or to open the folder where the file is located.

When archiving the file, it will be renamed `PersonalizationStore_yyyyMMdd.xml` where `yyyyMMdd` is the current date.

## Note about deleting the file

If you delete the PersonalizationStore.xml file when the WIndows client is running, the file will be deleted but will reappear when the user closes the Windows client.

## Localization

The application is localized in English and in French.
This is my first attempt in localizing an application so it is maybe not pretty but it's work :)
