lazy val root = (project in file(".")).
  settings(
    organization := "com.sphereon.sdk",
    name := "named-entity-extraction-sdk-java8-retrofit2",
    version := "0.1.0-SNAPSHOT",
    scalaVersion := "2.11.4",
    scalacOptions ++= Seq("-feature"),
    javacOptions in compile ++= Seq("-Xlint:deprecation"),
    publishArtifact in (Compile, packageDoc) := false,
    resolvers += Resolver.mavenLocal,
    libraryDependencies ++= Seq(
      "com.squareup.retrofit2" % "retrofit" % "2.3.0" % "compile",
      "com.squareup.retrofit2" % "converter-scalars" % "2.3.0" % "compile",
      "com.squareup.retrofit2" % "converter-gson" % "2.3.0" % "compile",
      "io.swagger" % "swagger-annotations" % "1.5.15" % "compile",
      "org.apache.oltu.oauth2" % "org.apache.oltu.oauth2.client" % "1.0.1" % "compile",
      "junit" % "junit" % "4.12" % "test",
      "com.novocode" % "junit-interface" % "0.11" % "test"
    )
  )
