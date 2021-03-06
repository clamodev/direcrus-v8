#import <Foundation/Foundation.h>
#import "DRCTSObject.h"

/**
* directus.io
* API for directus.io
*
* OpenAPI spec version: 1.1
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


#import "DRCTSGetMessagesData.h"
#import "DRCTSGetMessagesMeta.h"
@protocol DRCTSGetMessagesData;
@class DRCTSGetMessagesData;
@protocol DRCTSGetMessagesMeta;
@class DRCTSGetMessagesMeta;



@protocol DRCTSGetMessages
@end

@interface DRCTSGetMessages : DRCTSObject


@property(nonatomic) DRCTSGetMessagesMeta* meta;

@property(nonatomic) NSArray<DRCTSGetMessagesData>* data;

@end
