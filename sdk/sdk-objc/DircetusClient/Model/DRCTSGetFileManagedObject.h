#import <Foundation/Foundation.h>
#import <CoreData/CoreData.h>

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


#import "DRCTSGetFilesDataManagedObject.h"
#import "DRCTSGetTablesMetaManagedObject.h"


NS_ASSUME_NONNULL_BEGIN

@interface DRCTSGetFileManagedObject : NSManagedObject


@property (nullable, nonatomic, retain) DRCTSGetTablesMetaManagedObject* meta;

@property (nullable, nonatomic, retain) DRCTSGetFilesDataManagedObject* data;
@end

@interface DRCTSGetFileManagedObject (GeneratedAccessors)

@end


NS_ASSUME_NONNULL_END
