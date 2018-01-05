# KeyboardMediaButtonsSend

This is an simple application that allows you to send media button commands in windows from any application.

I use this from my keyboard which has programmable buttons but no Next/Previous media buttons. 

 
  - Works when focused application is running as Administrator ( Visual Studio anyone )
  - Supports all the media enums that exists in windows.
  - The commands are not case sensitive.
  
# Howto:
Put the exe file somewhere (c:\windows, c:\programfiles\stuff\..) and then use the keyboard configurator or the triggering application you want to use ("Microsoft mouse and Keyboard Center" is the one for Microsoft keyboards with extra buttons) 

Then in the configuration for that button set "C:\Program Files\stuff\MediaButtonsSend.exe" MyCommand where MyCommand is any Windows enum Name from the list below.

"C:\Program Files\stuff\MediaButtonsSend.exe" MediaNext

"C:\Program Files\stuff\MediaButtonsSend.exe" MediaPrevious are prime examples. 


# Supported Media Commands:

| WM_APPCOMMAND | Decimal value | Windows enum name | Notes |
| ------ | ------ | ------ | ------ |
| APPCOMMAND_BROWSER_BACKWARD | 1 | BrowserBack | Navigate backward. |
| APPCOMMAND_BROWSER_FORWARD | 2 | BrowserForward | Navigate forward. |
| APPCOMMAND_BROWSER_REFRESH | 3 | BrowserRefresh | Refresh page. |
| APPCOMMAND_BROWSER_STOP | 4 | BrowserStop | Stop download. |
| APPCOMMAND_BROWSER_SEARCH | 5 | BrowserSearch | Open search. |
| APPCOMMAND_BROWSER_FAVORITES | 6 | BrowserFavorite | Open favorites. |
| APPCOMMAND_BROWSER_HOME | 7 | BrowserHome | Navigate home. |
| APPCOMMAND_VOLUME_MUTE | 8 | VolumeMute | Mute the volume. |
| APPCOMMAND_VOLUME_DOWN | 9 | **VolumeDown** | Lower the volume. |
| APPCOMMAND_VOLUME_UP | 10 | **VolumeUp** | Raise the volume. |
| APPCOMMAND_MEDIA_NEXTTRACK | 11 | **MediaNext** | Go to next track. |
| APPCOMMAND_MEDIA_PREVIOUSTRACK | 12 | **MediaPrevious** | Go to previous track. |
| APPCOMMAND_MEDIA_STOP | 13 | **MediaStop** | Stop playback. |
| APPCOMMAND_MEDIA_PLAY_PAUSE | 14 | MediaPlayPause | Play or pause playback. If there are discrete Play and Pause buttons, applications should take action on this command as well as APPCOMMAND_MEDIA_PLAY and APPCOMMAND_MEDIA_PAUSE. |
| APPCOMMAND_LAUNCH_MAIL | 15 | LaunchMail | Open mail. |
| APPCOMMAND_LAUNCH_MEDIA_SELECT | 16 | LaunchMediaSelect | Go to Media Select mode. |
| APPCOMMAND_LAUNCH_APP1 | 17 | LaunchApp1 | Start App1. |
| APPCOMMAND_LAUNCH_APP2 | 18 | LaunchApp2 | Start App2. |
| APPCOMMAND_BASS_DOWN | 19 | BassDown | Decrease the bass. |
| APPCOMMAND_BASS_BOOST | 20 | BassBoost | Toggle the bass boost on and off. |
| APPCOMMAND_BASS_UP | 21 | BassUp | Increase the bass. |
| APPCOMMAND_TREBLE_DOWN | 22 | TrebleUp | Decrease the treble. |
| APPCOMMAND_TREBLE_UP | 23 | TrebleDown | Increase the treble. |
| APPCOMMAND_MICROPHONE_VOLUME_MUTE | 24 | MicrophoneMute | Mute the microphone. |
| APPCOMMAND_MICROPHONE_VOLUME_DOWN | 25 | MicrophoneVolumeUp | Increase microphone volume. |
| APPCOMMAND_MICROPHONE_VOLUME_UP | 26 | MicrophoneVolumeDown | Decrease microphone volume. |
| APPCOMMAND_HELP | 27 | Help | Open the Help dialog. |
| APPCOMMAND_FIND | 28 | Find | Open the Find dialog. |
| APPCOMMAND_NEW | 29 | New | Create a new window. |
| APPCOMMAND_OPEN | 30 | Open | Open a window. |
| APPCOMMAND_CLOSE | 31 | Close | Close the window (not the application). |
| APPCOMMAND_SAVE | 32 | Save | Save current document. |
| APPCOMMAND_PRINT | 33 | Print | Print current document. |
| APPCOMMAND_UNDO | 34 | Undo | Undo last action. |
| APPCOMMAND_REDO | 35 | Redo | Redo last action. |
| APPCOMMAND_COPY | 36 | Copy | Copy the selection. |
| APPCOMMAND_CUT | 37 | Cut | Cut the selection. |
| APPCOMMAND_PASTE | 38 | Paste | Paste |
| APPCOMMAND_REPLY_TO_MAIL | 39 | ReplyToMail | Reply to a mail message. |
| APPCOMMAND_FORWARD_MAIL | 40 | ForwardMail | Forward a mail message. |
| APPCOMMAND_SEND_MAIL | 41 | SendMail | Send a mail message. |
| APPCOMMAND_SPELL_CHECK | 42 | SpellCheck | Initiate a spell check. |
| APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE | 43 | Dictate | Toggles between two modes of speech input: dictation and command/control (giving commands to an application or accessing menus). |
| APPCOMMAND_MIC_ON_OFF_TOGGLE | 44 | MicrophoneOnOff | Toggle the microphone. |
| APPCOMMAND_CORRECTION_LIST | 45 | CorrectionList | Brings up the correction list when a word is incorrectly identified during speech input. |
| APPCOMMAND_MEDIA_PLAY | 46 | MediaPlay | Begin playing at the current position. If already paused, it will resume. This is a direct PLAY command that has no state. If there are discrete Play and Pause buttons, applications should take action on this command as well as APPCOMMAND_MEDIA_PLAY_PAUSE. |
| APPCOMMAND_MEDIA_PAUSE | 47 | MediaPause | Pause. If already paused, take no further action. This is a direct PAUSE command that has no state. If there are discrete Play and Pause buttons, applications should take action on this command as well as APPCOMMAND_MEDIA_PLAY_PAUSE. |
| APPCOMMAND_MEDIA_RECORD | 48 | MediaRecord | Begin recording the current stream. |
| APPCOMMAND_MEDIA_FAST_FORWARD | 49 | MediaFastForward | Increase the speed of stream playback. This can be implemented in many ways, for example, using a fixed speed or toggling through a series of increasing speeds. |
| APPCOMMAND_MEDIA_REWIND | 50 | MediaRewind | Go backward in a stream at a higher rate of speed. This can be implemented in many ways, for example, using a fixed speed or toggling through a series of increasing speeds. |
| APPCOMMAND_MEDIA_CHANNEL_UP | 51 | MediaChannelUp | Increment the channel value, for example, for a TV or radio tuner. |
| APPCOMMAND_MEDIA_CHANNEL_DOWN | 52 | MediaChannelDown | Decrement the channel value, for example, for a TV or radio tuner. |

For more information look at  https://msdn.microsoft.com/en-us/library/windows/desktop/ms646275(v=vs.85).aspx
