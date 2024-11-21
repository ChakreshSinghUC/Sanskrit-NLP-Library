cmake_minimum_required(VERSION 3.10)
cmake_policy(SET CMP0074 NEW)
project(SanskritNLP)

set(CMAKE_CXX_STANDARD 17)

# Find ICU package
find_package(ICU REQUIRED COMPONENTS uc i18n)

include_directories(${ICU_INCLUDE_DIR})
link_directories(${ICU_LIBRARY_DIR})

# Add include directory for project headers
include_directories(${CMAKE_SOURCE_DIR}/include)

# Add source files for Transliteration and UnicodeSupport
set(SOURCE_FILES
    src/main.cpp
    src/transliteration.cpp
    src/unicode_support.cpp
)

add_executable(SanskritNLP ${SOURCE_FILES})
target_link_libraries(SanskritNLP ${ICU_LIBRARIES})