# MangaDex.Model.StatisticsDetailsComments
Comments-related statistics of an entity. If it is `null`, the entity doesn't have a backing comments thread, and therefore has no comments yet. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **decimal** | The id of the thread backing the comments for that entity on the MangaDex Forums. | [optional] 
**RepliesCount** | **decimal** | The number of replies on the MangaDex Forums thread backing this entity&#39;s comments. This excludes the initial comment that opens the thread, which is created by our systems.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

