# Sanskrit-NLP-Library
A high-performance C++ library for processing and analyzing Classical Sanskrit

# Sanskrit NLP Library

![C++](https://img.shields.io/badge/language-C%2B%2B-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-Development-yellow)

## Overview
**Sanskrit NLP Library** is a high-performance open-source C++ library designed to process and analyze Classical Sanskrit texts. The library provides tools for tokenization, morphological analysis, transliteration, and syntax parsing, leveraging the rich grammatical framework of Sanskrit.

## Features
- **Unicode Support**: Handle Devanagari script and transliteration schemes like IAST and ISO 15919.
- **Tokenization**: Robust handling of Sanskrit Sandhi rules and word segmentation.
- **Morphological Analysis**: Identify roots, suffixes, and stems based on Paninian grammar.
- **Transliteration Tools**: Convert between Devanagari and Romanized scripts.
- **Syntax Parsing**: Analyze the syntactic structure of sentences using dependency-based parsing.

## Planned Features
1. **Phase 1: Foundational Tools**
   - Unicode support and transliteration.
   - Basic tokenization with Sandhi splitting.
   - Morphological analysis for stems and suffixes.

2. **Phase 2: Advanced Parsing**
   - Dependency parsing for free word order.
   - Sandhi splitting and joining tools.

3. **Phase 3: Semantic Tools**
   - Named Entity Recognition (NER) for proper nouns and places.
   - Semantic role labeling (e.g., karta, karma relationships).

## Getting Started

### Prerequisites
- **C++17 or later**: Ensure you have a compatible compiler (e.g., `g++-17` or `clang++`).
- **CMake**: For build configuration and management.
- **ICU Library**: For Unicode handling.
- **Boost**: For string processing utilities.

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Sanskrit-NLP-Library.git
   cd Sanskrit-NLP-Library

