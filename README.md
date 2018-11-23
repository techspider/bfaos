# Better FlashAir Operating System (BFAOS)

BFAOS is a collection of software to improve your FlashAir WiFi SD card experience.

It contains 

- An all new web interface for browsing files
- An improved configuration tool
- [COMING SOON] An improved mobile app for browsing files

## Requirements
- W-04 FlashAir card (W-03 is being considered)

## Installing BFAOS on your FlashAir

Installing BFAOS is very easy and requires minor tweaks to the SD_WLAN/CONFIG file.

This simplified step-by-step guide is for installing the BFAOS web interface. The configurator and (possible) mobile app are not required.

Step-by-step tutorial

1. Copy List.htm from SD_WLAN to your card's SD_WLAN folder (usually `<drive_letter>:\\SD_WLAN`). Keep in mind that the `SD_WLAN` folder is hidden.
2. Add `UPLOAD=1` to `<drive_letter>:\\SD_WLAN\\CONFIG` to enable file uploads from the web interface
3. Copy the `private_bfaos` folder to the root of your FlashAir SD card.

If all steps are followed correctly, the newly installed web interface and its components should show up when accessing either `flashair/` or `192.168.0.1`.

## Credits

Oxygen Icons (https://github.com/pasnox/oxygen-icons-png)

Material Icons (http://material.io/tools/icons)

Buuf Icons (https://www.gnome-look.org/p/1012512/)