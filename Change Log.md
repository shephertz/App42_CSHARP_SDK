* [Release Version 2.2](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-22)
* [Release Version 2.1](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-21)
* [Release Version 2.0](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-20)
* [Release Version 1.9.1](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-191)
* [Release Version 1.9](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-19)
* [Release Version 1.8](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-18)
* [Release Version 1.7](https://github.com/shephertz/App42_CSHARP_SDK/blob/master/Change%20Log.md#version-17)

## Version 2.2

**Release Date:** 30-07-2014

**Release Version:** 2.2

**The following Services have been pushed to the latest :**

```
1.Timer Service.
2.Gift Service.
```

**The following features have been pushed to the services :**

**PUSH NOTIFICATION SERVICE**
```
1.DeleteChannel.
2.GetChannelUsersCount.
3.GetChannelUsers.
4.GetUserSubscribedChannelsCount.
5.GetUserSubscribedChannels.
6.DeleteAllDevices.
7.SendPushMessageToDevice.
8.UpdatePushBadgeforDevice.
9.UpdatePushBadgeforUser.
10.ClearAllBadgeCount.
```

**AVATAR SERVICE**
```
1.UpdateAvatar.
2.DeleteAvatarByName.
3.DeleteAllAvatars.
```

**This release contains the following bug fix:**
```
None.
```


## Version 2.1

**Release Date:** 26-03-2014

**Release Version:** 2.1

**The following features have been changed :**

```
If you are upgrading from previous version of App42_CSHARP_SDK and have used SetQuery method on any service, you have to set App42API.SetDbName instead of passing it in method parameter.

**OlD Code Snippet:
SetQuery("dbName","collectionName","query");

**New Code Snippet :
App42API.SetDbName("dbName");
SetQuery("collectionName","query");
```

**The following features have been pushed to the services :**

**STORAGE SERVICE**

```
1.AddOrUpdateKeys.
2.AddAttachmentToDocs.
3.InsertJSONDocument(With Attached File).
```

**User SERVICE**

```
1.AddJSONObject(Add Extra Information while creating user).
2.CreateUserWithProfile.
3.GetUsersByGroup.
```

**PUSH NOTIFICATION SERVICE**
```
1.UnSubscribeDevice.
2.ReSubscribeDevice.
```

**REVIEW SERVICE**
```
1.GetAllReviewsByUser.
```

**SCOREBOARD SERVICE**
```
1.AddJSONObject(Add Extra Information of user while saving score).
```

**This release contains the following bug fix:**

```
None.
```


## Version 2.0

**Release Date:** 06-02-2014

**Release Version:** 2.0

**The following features have been pushed to the services :**

**The following features have been pushed  :**

```
MetaInfo in UserService (GetUser, GetUsersByRole, GetUserByEmailId) and ScoreBoardService(GetTopNRankers, GetTopNTargetRankers).
```

**STORAGE SERVICE**
```
1.Inlist Support for storage query.
2.UpdateDocumentByQuery.
```

**PHOTO SERVICE**
```
1.UpdatePhoto.
```

**PUSH NOTIFICATION SERVICE**
```
1.SendMessageToInactiveUsers.
2.ScheduleMessageToUser.
```

**REVIEW SERVICE**
```
1.DeleteReviewByReviewId.
2.DeleteCommentByCommentId.
```

**SCOREBOARD SERVICE**
```
1.GetTopNTargetRankers.
2.GetTopNRankersFromFacebook(including rankers in specified date range).
```

**BUDDY SERVICE**
```
1.Unfriend.
2.DeleteMessageById.
3.DeleteMessageByIds.
```

**This release contains the following bug fix:**

```
None.
```

## Version 1.9.1

**Release Date:** 17-12-2013

**Release Version:** 1.9.1

**This release contains the following bug fix:**

```
1.Total Records Count Fixed.
```

## Version 1.9

**Release Date:** 25-10-2013

**Release Version:** 1.9

**The following features have been pushed to the services :**

**PUSH SERVICE**

```
SendPushToTargetUsers
```

**STORAGE SERVICE**

```
SaveOrUpdateDocumentByKeyValue
```

**This release contains the following bug fix:**

```
None
```

## Version 1.8

**Release Date:** 23-10-2013

**Release Version:** 1.8

**The following Services have been pushed to the latest :**

```
AB Test Service
```

**This release contains the following bug fix:**

```
None
```
**Note :-** New Async API For All Methods & Now support .net verson 3.5.


## Version 1.7

**Release Date:** 23-09-2013

**Release Version:** 1.7

**The following Services have been pushed to the latest :**

```
Achievement Service
Avatar Service
```

**The following features have been pushed to the services :**

**SOCIAL SERVICE**

```
FacebookPublishStream
FacebookLinkPost
FacebookLinkPostWithCustomThumbnail
GetFacebookProfile
```

**SCOREBOARD SERVICE**

```
GetTopNRankersFromFacebook
```

**PUSHNOTIFICATION SERVICE**

```
SendPushMessageToGroup
DeleteDeviceToken
```

**LOG SERVICE**

```
SetEvent(eventName)
SetEvent(moduleName,eventName)
```


**This release contains the following bug fix:**

```
None
```

**Note :-** New Async API For All Methods & Now support .net verson 3.5.

