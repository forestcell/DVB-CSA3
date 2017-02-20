using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA3
{
    class CSA3_TestVectors
    {
        public static string passwd = "00112233445566778899aabbccddeeff";
        public static string iv= "445642544d4350544145534349535341";

        //  case 1 : No Adaptation Field
        public static string CASE_1_TS_clear       = @"47 60 80 11 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f 64 65 73 63 72 61 6d 62 6c 65 72 2e 20 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f 64 65 73 63 72 61 6d";
        public static string CASE_1_TS_Scrambled   = @"47 60 80 91 15 ce 67 e0 cb 01 b5 3c e7 60 54 e5 7a 4a d1 20 a0 df a4 ea aa e9 32 c6 78 3f 51 ae 19 fa ee 10 8b db 78 f3 11 3e c2 b5 72 cc 20 85 00 a5 2c ec a1 14 12 6c 58 24 4d f5 63 e7 a9 b4 e0 41 cb c3 fb ff fb d8 3c 8f bf fb 10 e8 3e a3 82 04 ba d7 02 fb 01 a2 7b 62 2c 4f 85 aa b6 aa 75 55 97 20 d6 5a b8 44 ce a2 8c f2 e1 fe 5e 7a c1 9d 44 81 89 19 c2 32 49 f1 40 75 7b 5d 16 c0 af 45 b2 5f 50 9b 9d a0 61 97 12 c5 9f 0b 39 b0 6f 1f be 90 12 3f 21 29 83 93 6a 95 31 7f cb 62 f4 34 6a 1b 1e 16 48 40 30 3a ff 83 8a 01 9b f8 10 a8 e0 b2 2f 64 65 73 63 72 61 6d";

        //  case 2 : 7-byte Adaptation Field
        public static string CASE_2_TS_clear       = @"47 60 80 31 06 00 FF FF FF FF FF 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f 64 65 73 63 72 61 6d 62 6c 65 72 2e 20 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f";
        public static string CASE_2_TS_Scrambled   = @"47 60 80 b1 06 00 FF FF FF FF FF 15 ce 67 e0 cb 01 b5 3c e7 60 54 e5 7a 4a d1 20 a0 df a4 ea aa e9 32 c6 78 3f 51 ae 19 fa ee 10 8b db 78 f3 11 3e c2 b5 72 cc 20 85 00 a5 2c ec a1 14 12 6c 58 24 4d f5 63 e7 a9 b4 e0 41 cb c3 fb ff fb d8 3c 8f bf fb 10 e8 3e a3 82 04 ba d7 02 fb 01 a2 7b 62 2c 4f 85 aa b6 aa 75 55 97 20 d6 5a b8 44 ce a2 8c f2 e1 fe 5e 7a c1 9d 44 81 89 19 c2 32 49 f1 40 75 7b 5d 16 c0 af 45 b2 5f 50 9b 9d a0 61 97 12 c5 9f 0b 39 b0 6f 1f be 90 12 3f 21 29 83 93 6a 95 31 7f cb 62 f4 34 6a 1b 1e 16 48 40 30 3a ff 83 8a 01 9b f8 10 a8 e0 b2 2f";

        //  case 3 : 8-byte Adaptation Field
        public static string CASE_3_TS_clear       = @"47 60 80 31 07 00 FF FF FF FF FF FF 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f 64 65 73 63 72 61 6d 62 6c 65 72 2e 20 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72";
        public static string CASE_3_TS_Scrambled   = @"47 60 80 b1 07 00 FF FF FF FF FF FF 15 ce 67 e0 cb 01 b5 3c e7 60 54 e5 7a 4a d1 20 a0 df a4 ea aa e9 32 c6 78 3f 51 ae 19 fa ee 10 8b db 78 f3 11 3e c2 b5 72 cc 20 85 00 a5 2c ec a1 14 12 6c 58 24 4d f5 63 e7 a9 b4 e0 41 cb c3 fb ff fb d8 3c 8f bf fb 10 e8 3e a3 82 04 ba d7 02 fb 01 a2 7b 62 2c 4f 85 aa b6 aa 75 55 97 20 d6 5a b8 44 ce a2 8c f2 e1 fe 5e 7a c1 9d 44 81 89 19 c2 32 49 f1 40 75 7b 5d 16 c0 af 45 b2 5f 50 9b 9d a0 61 97 12 c5 9f 0b 39 b0 6f 1f be 90 12 3f 21 29 83 93 6a 95 31 7f cb 62 f4 34 6a 1b 1e 16 48 40 30 3a ff 83 8a 01 9b f8 10 a8 e0 b2";

        //  case 4 : 9-byte Adaptation Field
        public static string CASE_4_TS_clear       = @"47 60 80 31 08 00 FF FF FF FF FF FF FF 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65 72 2f 64 65 73 63 72 61 6d 62 6c 65 72 2e 20 54 68 69 73 20 69 73 20 74 68 65 20 70 61 79 6c 6f 61 64 20 75 73 65 64 20 66 6f 72 20 63 72 65 61 74 69 6e 67 20 74 68 65 20 74 65 73 74 20 76 65 63 74 6f 72 73 20 66 6f 72 20 74 68 65 20 44 56 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65";
        public static string CASE_4_TS_Scrambled   = @"47 60 80 b1 08 00 FF FF FF FF FF FF FF 15 ce 67 e0 cb 01 b5 3c e7 60 54 e5 7a 4a d1 20 a0 df a4 ea aa e9 32 c6 78 3f 51 ae 19 fa ee 10 8b db 78 f3 11 3e c2 b5 72 cc 20 85 00 a5 2c ec a1 14 12 6c 58 24 4d f5 63 e7 a9 b4 e0 41 cb c3 fb ff fb d8 3c 8f bf fb 10 e8 3e a3 82 04 ba d7 02 fb 01 a2 7b 62 2c 4f 85 aa b6 aa 75 55 97 20 d6 5a b8 44 ce a2 8c f2 e1 fe 5e 7a c1 9d 44 81 89 19 c2 32 49 f1 40 75 7b 5d 16 c0 af 45 b2 5f 50 9b 9d a0 61 97 12 c5 9f 0b 39 b0 6f 1f be 90 12 3f 21 29 83 93 6a 95 31 7f cb 62 f4 34 6a 1b 42 20 49 50 54 56 20 73 63 72 61 6d 62 6c 65";
    }
}
