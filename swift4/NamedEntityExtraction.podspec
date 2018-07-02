Pod::Spec.new do |s|
  s.name = 'NamedEntityExtraction'
  s.ios.deployment_target = '9.0'
  s.osx.deployment_target = '10.11'
  s.version = '0.10.3'
  s.source = "{ :git => 'https://github.com/Sphereon-SDK/named-entity-extraction-sdk.git', :tag => '0.1.0' }"
  s.authors = 'Sphereon BV'
  s.license = Apache2
  s.homepage = 'https://sphereon.com'
  s.description = 'Named Entity Extraction Swift4 SDK'
  s.source_files = 'NamedEntityExtraction/Classes/Swaggers/**/*.swift'
  s.dependency 'Alamofire', '~> 4.5'
end
