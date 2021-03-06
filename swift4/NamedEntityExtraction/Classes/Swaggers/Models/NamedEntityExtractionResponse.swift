//
// NamedEntityExtractionResponse.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


/** Name entity extraction response for a job */
open class NamedEntityExtractionResponse: Codable {

    public var jobId: String?
    /** The name entities that are extracted for each input */
    public var namedEntities: [String:NamedEntityList]?
    /** The extraction job */
    public var job: Job?
    /** The errors that occurred */
    public var errors: [String]?

    public init() {}

}
