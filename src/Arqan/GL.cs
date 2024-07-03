using System;
using System.Runtime.InteropServices;

namespace Arqan
{
    public static class GL
    {
        #region Constants
        
        public const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
		public const uint GL_STENCIL_BUFFER_BIT = 0x00000400;
		public const uint GL_COLOR_BUFFER_BIT = 0x00004000;
		public const uint GL_FALSE = 0;
		public const uint GL_TRUE = 1;
		public const uint GL_POINTS = 0x0000;
		public const uint GL_LINES = 0x0001;
		public const uint GL_LINE_LOOP = 0x0002;
		public const uint GL_LINE_STRIP = 0x0003;
		public const uint GL_TRIANGLES = 0x0004;
		public const uint GL_TRIANGLE_STRIP = 0x0005;
		public const uint GL_TRIANGLE_FAN = 0x0006;
		public const uint GL_QUADS = 0x0007;
		public const uint GL_NEVER = 0x0200;
		public const uint GL_LESS = 0x0201;
		public const uint GL_EQUAL = 0x0202;
		public const uint GL_LEQUAL = 0x0203;
		public const uint GL_GREATER = 0x0204;
		public const uint GL_NOTEQUAL = 0x0205;
		public const uint GL_GEQUAL = 0x0206;
		public const uint GL_ALWAYS = 0x0207;
		public const uint GL_ZERO = 0;
		public const uint GL_ONE = 1;
		public const uint GL_SRC_COLOR = 0x0300;
		public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint GL_SRC_ALPHA = 0x0302;
		public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint GL_DST_ALPHA = 0x0304;
		public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint GL_DST_COLOR = 0x0306;
		public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const uint GL_SRC_ALPHA_SATURATE = 0x0308;
		public const uint GL_NONE = 0;
		public const uint GL_FRONT_LEFT = 0x0400;
		public const uint GL_FRONT_RIGHT = 0x0401;
		public const uint GL_BACK_LEFT = 0x0402;
		public const uint GL_BACK_RIGHT = 0x0403;
		public const uint GL_FRONT = 0x0404;
		public const uint GL_BACK = 0x0405;
		public const uint GL_LEFT = 0x0406;
		public const uint GL_RIGHT = 0x0407;
		public const uint GL_FRONT_AND_BACK = 0x0408;
		public const uint GL_NO_ERROR = 0;
		public const uint GL_INVALID_ENUM = 0x0500;
		public const uint GL_INVALID_VALUE = 0x0501;
		public const uint GL_INVALID_OPERATION = 0x0502;
		public const uint GL_OUT_OF_MEMORY = 0x0505;
		public const uint GL_CW = 0x0900;
		public const uint GL_CCW = 0x0901;
		public const uint GL_POINT_SIZE = 0x0B11;
		public const uint GL_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_LINE_SMOOTH = 0x0B20;
		public const uint GL_LINE_WIDTH = 0x0B21;
		public const uint GL_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_POLYGON_MODE = 0x0B40;
		public const uint GL_POLYGON_SMOOTH = 0x0B41;
		public const uint GL_CULL_FACE = 0x0B44;
		public const uint GL_CULL_FACE_MODE = 0x0B45;
		public const uint GL_FRONT_FACE = 0x0B46;
		public const uint GL_DEPTH_RANGE = 0x0B70;
		public const uint GL_DEPTH_TEST = 0x0B71;
		public const uint GL_DEPTH_WRITEMASK = 0x0B72;
		public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73;
		public const uint GL_DEPTH_FUNC = 0x0B74;
		public const uint GL_STENCIL_TEST = 0x0B90;
		public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91;
		public const uint GL_STENCIL_FUNC = 0x0B92;
		public const uint GL_STENCIL_VALUE_MASK = 0x0B93;
		public const uint GL_STENCIL_FAIL = 0x0B94;
		public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const uint GL_STENCIL_REF = 0x0B97;
		public const uint GL_STENCIL_WRITEMASK = 0x0B98;
		public const uint GL_VIEWPORT = 0x0BA2;
		public const uint GL_DITHER = 0x0BD0;
		public const uint GL_BLEND_DST = 0x0BE0;
		public const uint GL_BLEND_SRC = 0x0BE1;
		public const uint GL_BLEND = 0x0BE2;
		public const uint GL_LOGIC_OP_MODE = 0x0BF0;
		public const uint GL_COLOR_LOGIC_OP = 0x0BF2;
		public const uint GL_DRAW_BUFFER = 0x0C01;
		public const uint GL_READ_BUFFER = 0x0C02;
		public const uint GL_SCISSOR_BOX = 0x0C10;
		public const uint GL_SCISSOR_TEST = 0x0C11;
		public const uint GL_COLOR_CLEAR_VALUE = 0x0C22;
		public const uint GL_COLOR_WRITEMASK = 0x0C23;
		public const uint GL_DOUBLEBUFFER = 0x0C32;
		public const uint GL_STEREO = 0x0C33;
		public const uint GL_LINE_SMOOTH_HINT = 0x0C52;
		public const uint GL_POLYGON_SMOOTH_HINT = 0x0C53;
		public const uint GL_UNPACK_SWAP_BYTES = 0x0CF0;
		public const uint GL_UNPACK_LSB_FIRST = 0x0CF1;
		public const uint GL_UNPACK_ROW_LENGTH = 0x0CF2;
		public const uint GL_UNPACK_SKIP_ROWS = 0x0CF3;
		public const uint GL_UNPACK_SKIP_PIXELS = 0x0CF4;
		public const uint GL_UNPACK_ALIGNMENT = 0x0CF5;
		public const uint GL_PACK_SWAP_BYTES = 0x0D00;
		public const uint GL_PACK_LSB_FIRST = 0x0D01;
		public const uint GL_PACK_ROW_LENGTH = 0x0D02;
		public const uint GL_PACK_SKIP_ROWS = 0x0D03;
		public const uint GL_PACK_SKIP_PIXELS = 0x0D04;
		public const uint GL_PACK_ALIGNMENT = 0x0D05;
		public const uint GL_MAX_TEXTURE_SIZE = 0x0D33;
		public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
		public const uint GL_SUBPIXEL_BITS = 0x0D50;
		public const uint GL_TEXTURE_1D = 0x0DE0;
		public const uint GL_TEXTURE_2D = 0x0DE1;
		public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00;
		public const uint GL_POLYGON_OFFSET_POINT = 0x2A01;
		public const uint GL_POLYGON_OFFSET_LINE = 0x2A02;
		public const uint GL_POLYGON_OFFSET_FILL = 0x8037;
		public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038;
		public const uint GL_TEXTURE_BINDING_1D = 0x8068;
		public const uint GL_TEXTURE_BINDING_2D = 0x8069;
		public const uint GL_TEXTURE_WIDTH = 0x1000;
		public const uint GL_TEXTURE_HEIGHT = 0x1001;
		public const uint GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const uint GL_TEXTURE_BORDER_COLOR = 0x1004;
		public const uint GL_TEXTURE_RED_SIZE = 0x805C;
		public const uint GL_TEXTURE_GREEN_SIZE = 0x805D;
		public const uint GL_TEXTURE_BLUE_SIZE = 0x805E;
		public const uint GL_TEXTURE_ALPHA_SIZE = 0x805F;
		public const uint GL_DONT_CARE = 0x1100;
		public const uint GL_FASTEST = 0x1101;
		public const uint GL_NICEST = 0x1102;
		public const uint GL_BYTE = 0x1400;
		public const uint GL_UNSIGNED_BYTE = 0x1401;
		public const uint GL_SHORT = 0x1402;
		public const uint GL_UNSIGNED_SHORT = 0x1403;
		public const uint GL_INT = 0x1404;
		public const uint GL_UNSIGNED_INT = 0x1405;
		public const uint GL_FLOAT = 0x1406;
		public const uint GL_DOUBLE = 0x140A;
		public const uint GL_STACK_OVERFLOW = 0x0503;
		public const uint GL_STACK_UNDERFLOW = 0x0504;
		public const uint GL_CLEAR = 0x1500;
		public const uint GL_AND = 0x1501;
		public const uint GL_AND_REVERSE = 0x1502;
		public const uint GL_COPY = 0x1503;
		public const uint GL_AND_INVERTED = 0x1504;
		public const uint GL_NOOP = 0x1505;
		public const uint GL_XOR = 0x1506;
		public const uint GL_OR = 0x1507;
		public const uint GL_NOR = 0x1508;
		public const uint GL_EQUIV = 0x1509;
		public const uint GL_INVERT = 0x150A;
		public const uint GL_OR_REVERSE = 0x150B;
		public const uint GL_COPY_INVERTED = 0x150C;
		public const uint GL_OR_INVERTED = 0x150D;
		public const uint GL_NAND = 0x150E;
		public const uint GL_SET = 0x150F;
		public const uint GL_TEXTURE = 0x1702;
		public const uint GL_COLOR = 0x1800;
		public const uint GL_DEPTH = 0x1801;
		public const uint GL_STENCIL = 0x1802;
		public const uint GL_STENCIL_INDEX = 0x1901;
		public const uint GL_DEPTH_COMPONENT = 0x1902;
		public const uint GL_RED = 0x1903;
		public const uint GL_GREEN = 0x1904;
		public const uint GL_BLUE = 0x1905;
		public const uint GL_ALPHA = 0x1906;
		public const uint GL_RGB = 0x1907;
		public const uint GL_RGBA = 0x1908;
		public const uint GL_POINT = 0x1B00;
		public const uint GL_LINE = 0x1B01;
		public const uint GL_FILL = 0x1B02;
		public const uint GL_KEEP = 0x1E00;
		public const uint GL_REPLACE = 0x1E01;
		public const uint GL_INCR = 0x1E02;
		public const uint GL_DECR = 0x1E03;
		public const uint GL_VENDOR = 0x1F00;
		public const uint GL_RENDERER = 0x1F01;
		public const uint GL_VERSION = 0x1F02;
		public const uint GL_EXTENSIONS = 0x1F03;
		public const uint GL_NEAREST = 0x2600;
		public const uint GL_LINEAR = 0x2601;
		public const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
		public const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
		public const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
		public const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703;
		public const uint GL_TEXTURE_MAG_FILTER = 0x2800;
		public const uint GL_TEXTURE_MIN_FILTER = 0x2801;
		public const uint GL_TEXTURE_WRAP_S = 0x2802;
		public const uint GL_TEXTURE_WRAP_T = 0x2803;
		public const uint GL_PROXY_TEXTURE_1D = 0x8063;
		public const uint GL_PROXY_TEXTURE_2D = 0x8064;
		public const uint GL_REPEAT = 0x2901;
		public const uint GL_R3_G3_B2 = 0x2A10;
		public const uint GL_RGB4 = 0x804F;
		public const uint GL_RGB5 = 0x8050;
		public const uint GL_RGB8 = 0x8051;
		public const uint GL_RGB10 = 0x8052;
		public const uint GL_RGB12 = 0x8053;
		public const uint GL_RGB16 = 0x8054;
		public const uint GL_RGBA2 = 0x8055;
		public const uint GL_RGBA4 = 0x8056;
		public const uint GL_RGB5_A1 = 0x8057;
		public const uint GL_RGBA8 = 0x8058;
		public const uint GL_RGB10_A2 = 0x8059;
		public const uint GL_RGBA12 = 0x805A;
		public const uint GL_RGBA16 = 0x805B;
		public const uint GL_CURRENT_BIT = 0x00000001;
		public const uint GL_POINT_BIT = 0x00000002;
		public const uint GL_LINE_BIT = 0x00000004;
		public const uint GL_POLYGON_BIT = 0x00000008;
		public const uint GL_POLYGON_STIPPLE_BIT = 0x00000010;
		public const uint GL_PIXEL_MODE_BIT = 0x00000020;
		public const uint GL_LIGHTING_BIT = 0x00000040;
		public const uint GL_FOG_BIT = 0x00000080;
		public const uint GL_ACCUM_BUFFER_BIT = 0x00000200;
		public const uint GL_VIEWPORT_BIT = 0x00000800;
		public const uint GL_TRANSFORM_BIT = 0x00001000;
		public const uint GL_ENABLE_BIT = 0x00002000;
		public const uint GL_HINT_BIT = 0x00008000;
		public const uint GL_EVAL_BIT = 0x00010000;
		public const uint GL_LIST_BIT = 0x00020000;
		public const uint GL_TEXTURE_BIT = 0x00040000;
		public const uint GL_SCISSOR_BIT = 0x00080000;
		public const uint GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;
		public const uint GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
		public const uint GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
		public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
		public const uint GL_QUAD_STRIP = 0x0008;
		public const uint GL_POLYGON = 0x0009;
		public const uint GL_ACCUM = 0x0100;
		public const uint GL_LOAD = 0x0101;
		public const uint GL_RETURN = 0x0102;
		public const uint GL_MULT = 0x0103;
		public const uint GL_ADD = 0x0104;
		public const uint GL_AUX0 = 0x0409;
		public const uint GL_AUX1 = 0x040A;
		public const uint GL_AUX2 = 0x040B;
		public const uint GL_AUX3 = 0x040C;
		public const uint GL_2D = 0x0600;
		public const uint GL_3D = 0x0601;
		public const uint GL_3D_COLOR = 0x0602;
		public const uint GL_3D_COLOR_TEXTURE = 0x0603;
		public const uint GL_4D_COLOR_TEXTURE = 0x0604;
		public const uint GL_PASS_THROUGH_TOKEN = 0x0700;
		public const uint GL_POINT_TOKEN = 0x0701;
		public const uint GL_LINE_TOKEN = 0x0702;
		public const uint GL_POLYGON_TOKEN = 0x0703;
		public const uint GL_BITMAP_TOKEN = 0x0704;
		public const uint GL_DRAW_PIXEL_TOKEN = 0x0705;
		public const uint GL_COPY_PIXEL_TOKEN = 0x0706;
		public const uint GL_LINE_RESET_TOKEN = 0x0707;
		public const uint GL_EXP = 0x0800;
		public const uint GL_EXP2 = 0x0801;
		public const uint GL_COEFF = 0x0A00;
		public const uint GL_ORDER = 0x0A01;
		public const uint GL_DOMAIN = 0x0A02;
		public const uint GL_PIXEL_MAP_I_TO_I = 0x0C70;
		public const uint GL_PIXEL_MAP_S_TO_S = 0x0C71;
		public const uint GL_PIXEL_MAP_I_TO_R = 0x0C72;
		public const uint GL_PIXEL_MAP_I_TO_G = 0x0C73;
		public const uint GL_PIXEL_MAP_I_TO_B = 0x0C74;
		public const uint GL_PIXEL_MAP_I_TO_A = 0x0C75;
		public const uint GL_PIXEL_MAP_R_TO_R = 0x0C76;
		public const uint GL_PIXEL_MAP_G_TO_G = 0x0C77;
		public const uint GL_PIXEL_MAP_B_TO_B = 0x0C78;
		public const uint GL_PIXEL_MAP_A_TO_A = 0x0C79;
		public const uint GL_VERTEX_ARRAY_POINTER = 0x808E;
		public const uint GL_NORMAL_ARRAY_POINTER = 0x808F;
		public const uint GL_COLOR_ARRAY_POINTER = 0x8090;
		public const uint GL_INDEX_ARRAY_POINTER = 0x8091;
		public const uint GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
		public const uint GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
		public const uint GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
		public const uint GL_SELECTION_BUFFER_POINTER = 0x0DF3;
		public const uint GL_CURRENT_COLOR = 0x0B00;
		public const uint GL_CURRENT_INDEX = 0x0B01;
		public const uint GL_CURRENT_NORMAL = 0x0B02;
		public const uint GL_CURRENT_TEXTURE_COORDS = 0x0B03;
		public const uint GL_CURRENT_RASTER_COLOR = 0x0B04;
		public const uint GL_CURRENT_RASTER_INDEX = 0x0B05;
		public const uint GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
		public const uint GL_CURRENT_RASTER_POSITION = 0x0B07;
		public const uint GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
		public const uint GL_CURRENT_RASTER_DISTANCE = 0x0B09;
		public const uint GL_POINT_SMOOTH = 0x0B10;
		public const uint GL_LINE_STIPPLE = 0x0B24;
		public const uint GL_LINE_STIPPLE_PATTERN = 0x0B25;
		public const uint GL_LINE_STIPPLE_REPEAT = 0x0B26;
		public const uint GL_LIST_MODE = 0x0B30;
		public const uint GL_MAX_LIST_NESTING = 0x0B31;
		public const uint GL_LIST_BASE = 0x0B32;
		public const uint GL_LIST_INDEX = 0x0B33;
		public const uint GL_POLYGON_STIPPLE = 0x0B42;
		public const uint GL_EDGE_FLAG = 0x0B43;
		public const uint GL_LIGHTING = 0x0B50;
		public const uint GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
		public const uint GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
		public const uint GL_LIGHT_MODEL_AMBIENT = 0x0B53;
		public const uint GL_SHADE_MODEL = 0x0B54;
		public const uint GL_COLOR_MATERIAL_FACE = 0x0B55;
		public const uint GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
		public const uint GL_COLOR_MATERIAL = 0x0B57;
		public const uint GL_FOG = 0x0B60;
		public const uint GL_FOG_INDEX = 0x0B61;
		public const uint GL_FOG_DENSITY = 0x0B62;
		public const uint GL_FOG_START = 0x0B63;
		public const uint GL_FOG_END = 0x0B64;
		public const uint GL_FOG_MODE = 0x0B65;
		public const uint GL_FOG_COLOR = 0x0B66;
		public const uint GL_ACCUM_CLEAR_VALUE = 0x0B80;
		public const uint GL_MATRIX_MODE = 0x0BA0;
		public const uint GL_NORMALIZE = 0x0BA1;
		public const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
		public const uint GL_PROJECTION_STACK_DEPTH = 0x0BA4;
		public const uint GL_TEXTURE_STACK_DEPTH = 0x0BA5;
		public const uint GL_MODELVIEW_MATRIX = 0x0BA6;
		public const uint GL_PROJECTION_MATRIX = 0x0BA7;
		public const uint GL_TEXTURE_MATRIX = 0x0BA8;
		public const uint GL_ATTRIB_STACK_DEPTH = 0x0BB0;
		public const uint GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
		public const uint GL_ALPHA_TEST = 0x0BC0;
		public const uint GL_ALPHA_TEST_FUNC = 0x0BC1;
		public const uint GL_ALPHA_TEST_REF = 0x0BC2;
		public const uint GL_INDEX_LOGIC_OP = 0x0BF1;
		public const uint GL_LOGIC_OP = 0x0BF1;
		public const uint GL_AUX_BUFFERS = 0x0C00;
		public const uint GL_INDEX_CLEAR_VALUE = 0x0C20;
		public const uint GL_INDEX_WRITEMASK = 0x0C21;
		public const uint GL_INDEX_MODE = 0x0C30;
		public const uint GL_RGBA_MODE = 0x0C31;
		public const uint GL_RENDER_MODE = 0x0C40;
		public const uint GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
		public const uint GL_POINT_SMOOTH_HINT = 0x0C51;
		public const uint GL_FOG_HINT = 0x0C54;
		public const uint GL_TEXTURE_GEN_S = 0x0C60;
		public const uint GL_TEXTURE_GEN_T = 0x0C61;
		public const uint GL_TEXTURE_GEN_R = 0x0C62;
		public const uint GL_TEXTURE_GEN_Q = 0x0C63;
		public const uint GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
		public const uint GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
		public const uint GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
		public const uint GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
		public const uint GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
		public const uint GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
		public const uint GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
		public const uint GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
		public const uint GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
		public const uint GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
		public const uint GL_MAP_COLOR = 0x0D10;
		public const uint GL_MAP_STENCIL = 0x0D11;
		public const uint GL_INDEX_SHIFT = 0x0D12;
		public const uint GL_INDEX_OFFSET = 0x0D13;
		public const uint GL_RED_SCALE = 0x0D14;
		public const uint GL_RED_BIAS = 0x0D15;
		public const uint GL_ZOOM_X = 0x0D16;
		public const uint GL_ZOOM_Y = 0x0D17;
		public const uint GL_GREEN_SCALE = 0x0D18;
		public const uint GL_GREEN_BIAS = 0x0D19;
		public const uint GL_BLUE_SCALE = 0x0D1A;
		public const uint GL_BLUE_BIAS = 0x0D1B;
		public const uint GL_ALPHA_SCALE = 0x0D1C;
		public const uint GL_ALPHA_BIAS = 0x0D1D;
		public const uint GL_DEPTH_SCALE = 0x0D1E;
		public const uint GL_DEPTH_BIAS = 0x0D1F;
		public const uint GL_MAX_EVAL_ORDER = 0x0D30;
		public const uint GL_MAX_LIGHTS = 0x0D31;
		public const uint GL_MAX_CLIP_PLANES = 0x0D32;
		public const uint GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
		public const uint GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
		public const uint GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
		public const uint GL_MAX_NAME_STACK_DEPTH = 0x0D37;
		public const uint GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
		public const uint GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
		public const uint GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
		public const uint GL_INDEX_BITS = 0x0D51;
		public const uint GL_RED_BITS = 0x0D52;
		public const uint GL_GREEN_BITS = 0x0D53;
		public const uint GL_BLUE_BITS = 0x0D54;
		public const uint GL_ALPHA_BITS = 0x0D55;
		public const uint GL_DEPTH_BITS = 0x0D56;
		public const uint GL_STENCIL_BITS = 0x0D57;
		public const uint GL_ACCUM_RED_BITS = 0x0D58;
		public const uint GL_ACCUM_GREEN_BITS = 0x0D59;
		public const uint GL_ACCUM_BLUE_BITS = 0x0D5A;
		public const uint GL_ACCUM_ALPHA_BITS = 0x0D5B;
		public const uint GL_NAME_STACK_DEPTH = 0x0D70;
		public const uint GL_AUTO_NORMAL = 0x0D80;
		public const uint GL_MAP1_COLOR_4 = 0x0D90;
		public const uint GL_MAP1_INDEX = 0x0D91;
		public const uint GL_MAP1_NORMAL = 0x0D92;
		public const uint GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
		public const uint GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
		public const uint GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
		public const uint GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
		public const uint GL_MAP1_VERTEX_3 = 0x0D97;
		public const uint GL_MAP1_VERTEX_4 = 0x0D98;
		public const uint GL_MAP2_COLOR_4 = 0x0DB0;
		public const uint GL_MAP2_INDEX = 0x0DB1;
		public const uint GL_MAP2_NORMAL = 0x0DB2;
		public const uint GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
		public const uint GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
		public const uint GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
		public const uint GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
		public const uint GL_MAP2_VERTEX_3 = 0x0DB7;
		public const uint GL_MAP2_VERTEX_4 = 0x0DB8;
		public const uint GL_MAP1_GRID_DOMAIN = 0x0DD0;
		public const uint GL_MAP1_GRID_SEGMENTS = 0x0DD1;
		public const uint GL_MAP2_GRID_DOMAIN = 0x0DD2;
		public const uint GL_MAP2_GRID_SEGMENTS = 0x0DD3;
		public const uint GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
		public const uint GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
		public const uint GL_SELECTION_BUFFER_SIZE = 0x0DF4;
		public const uint GL_VERTEX_ARRAY = 0x8074;
		public const uint GL_NORMAL_ARRAY = 0x8075;
		public const uint GL_COLOR_ARRAY = 0x8076;
		public const uint GL_INDEX_ARRAY = 0x8077;
		public const uint GL_TEXTURE_COORD_ARRAY = 0x8078;
		public const uint GL_EDGE_FLAG_ARRAY = 0x8079;
		public const uint GL_VERTEX_ARRAY_SIZE = 0x807A;
		public const uint GL_VERTEX_ARRAY_TYPE = 0x807B;
		public const uint GL_VERTEX_ARRAY_STRIDE = 0x807C;
		public const uint GL_NORMAL_ARRAY_TYPE = 0x807E;
		public const uint GL_NORMAL_ARRAY_STRIDE = 0x807F;
		public const uint GL_COLOR_ARRAY_SIZE = 0x8081;
		public const uint GL_COLOR_ARRAY_TYPE = 0x8082;
		public const uint GL_COLOR_ARRAY_STRIDE = 0x8083;
		public const uint GL_INDEX_ARRAY_TYPE = 0x8085;
		public const uint GL_INDEX_ARRAY_STRIDE = 0x8086;
		public const uint GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
		public const uint GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
		public const uint GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
		public const uint GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
		public const uint GL_TEXTURE_COMPONENTS = 0x1003;
		public const uint GL_TEXTURE_BORDER = 0x1005;
		public const uint GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
		public const uint GL_TEXTURE_INTENSITY_SIZE = 0x8061;
		public const uint GL_TEXTURE_PRIORITY = 0x8066;
		public const uint GL_TEXTURE_RESIDENT = 0x8067;
		public const uint GL_AMBIENT = 0x1200;
		public const uint GL_DIFFUSE = 0x1201;
		public const uint GL_SPECULAR = 0x1202;
		public const uint GL_POSITION = 0x1203;
		public const uint GL_SPOT_DIRECTION = 0x1204;
		public const uint GL_SPOT_EXPONENT = 0x1205;
		public const uint GL_SPOT_CUTOFF = 0x1206;
		public const uint GL_CONSTANT_ATTENUATION = 0x1207;
		public const uint GL_LINEAR_ATTENUATION = 0x1208;
		public const uint GL_QUADRATIC_ATTENUATION = 0x1209;
		public const uint GL_COMPILE = 0x1300;
		public const uint GL_COMPILE_AND_EXECUTE = 0x1301;
		public const uint GL_2_BYTES = 0x1407;
		public const uint GL_3_BYTES = 0x1408;
		public const uint GL_4_BYTES = 0x1409;
		public const uint GL_EMISSION = 0x1600;
		public const uint GL_SHININESS = 0x1601;
		public const uint GL_AMBIENT_AND_DIFFUSE = 0x1602;
		public const uint GL_COLOR_INDEXES = 0x1603;
		public const uint GL_MODELVIEW = 0x1700;
		public const uint GL_PROJECTION = 0x1701;
		public const uint GL_COLOR_INDEX = 0x1900;
		public const uint GL_LUMINANCE = 0x1909;
		public const uint GL_LUMINANCE_ALPHA = 0x190A;
		public const uint GL_BITMAP = 0x1A00;
		public const uint GL_RENDER = 0x1C00;
		public const uint GL_FEEDBACK = 0x1C01;
		public const uint GL_SELECT = 0x1C02;
		public const uint GL_FLAT = 0x1D00;
		public const uint GL_SMOOTH = 0x1D01;
		public const uint GL_S = 0x2000;
		public const uint GL_T = 0x2001;
		public const uint GL_R = 0x2002;
		public const uint GL_Q = 0x2003;
		public const uint GL_MODULATE = 0x2100;
		public const uint GL_DECAL = 0x2101;
		public const uint GL_TEXTURE_ENV_MODE = 0x2200;
		public const uint GL_TEXTURE_ENV_COLOR = 0x2201;
		public const uint GL_TEXTURE_ENV = 0x2300;
		public const uint GL_EYE_LINEAR = 0x2400;
		public const uint GL_OBJECT_LINEAR = 0x2401;
		public const uint GL_SPHERE_MAP = 0x2402;
		public const uint GL_TEXTURE_GEN_MODE = 0x2500;
		public const uint GL_OBJECT_PLANE = 0x2501;
		public const uint GL_EYE_PLANE = 0x2502;
		public const uint GL_CLAMP = 0x2900;
		public const uint GL_ALPHA4 = 0x803B;
		public const uint GL_ALPHA8 = 0x803C;
		public const uint GL_ALPHA12 = 0x803D;
		public const uint GL_ALPHA16 = 0x803E;
		public const uint GL_LUMINANCE4 = 0x803F;
		public const uint GL_LUMINANCE8 = 0x8040;
		public const uint GL_LUMINANCE12 = 0x8041;
		public const uint GL_LUMINANCE16 = 0x8042;
		public const uint GL_LUMINANCE4_ALPHA4 = 0x8043;
		public const uint GL_LUMINANCE6_ALPHA2 = 0x8044;
		public const uint GL_LUMINANCE8_ALPHA8 = 0x8045;
		public const uint GL_LUMINANCE12_ALPHA4 = 0x8046;
		public const uint GL_LUMINANCE12_ALPHA12 = 0x8047;
		public const uint GL_LUMINANCE16_ALPHA16 = 0x8048;
		public const uint GL_INTENSITY = 0x8049;
		public const uint GL_INTENSITY4 = 0x804A;
		public const uint GL_INTENSITY8 = 0x804B;
		public const uint GL_INTENSITY12 = 0x804C;
		public const uint GL_INTENSITY16 = 0x804D;
		public const uint GL_V2F = 0x2A20;
		public const uint GL_V3F = 0x2A21;
		public const uint GL_C4UB_V2F = 0x2A22;
		public const uint GL_C4UB_V3F = 0x2A23;
		public const uint GL_C3F_V3F = 0x2A24;
		public const uint GL_N3F_V3F = 0x2A25;
		public const uint GL_C4F_N3F_V3F = 0x2A26;
		public const uint GL_T2F_V3F = 0x2A27;
		public const uint GL_T4F_V4F = 0x2A28;
		public const uint GL_T2F_C4UB_V3F = 0x2A29;
		public const uint GL_T2F_C3F_V3F = 0x2A2A;
		public const uint GL_T2F_N3F_V3F = 0x2A2B;
		public const uint GL_T2F_C4F_N3F_V3F = 0x2A2C;
		public const uint GL_T4F_C4F_N3F_V4F = 0x2A2D;
		public const uint GL_CLIP_PLANE0 = 0x3000;
		public const uint GL_CLIP_PLANE1 = 0x3001;
		public const uint GL_CLIP_PLANE2 = 0x3002;
		public const uint GL_CLIP_PLANE3 = 0x3003;
		public const uint GL_CLIP_PLANE4 = 0x3004;
		public const uint GL_CLIP_PLANE5 = 0x3005;
		public const uint GL_LIGHT0 = 0x4000;
		public const uint GL_LIGHT1 = 0x4001;
		public const uint GL_LIGHT2 = 0x4002;
		public const uint GL_LIGHT3 = 0x4003;
		public const uint GL_LIGHT4 = 0x4004;
		public const uint GL_LIGHT5 = 0x4005;
		public const uint GL_LIGHT6 = 0x4006;
		public const uint GL_LIGHT7 = 0x4007;
        public const uint GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_PACK_SKIP_IMAGES = 0x806B;
		public const uint GL_PACK_IMAGE_HEIGHT = 0x806C;
		public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
		public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint GL_TEXTURE_3D = 0x806F;
		public const uint GL_PROXY_TEXTURE_3D = 0x8070;
		public const uint GL_TEXTURE_DEPTH = 0x8071;
		public const uint GL_TEXTURE_WRAP_R = 0x8072;
		public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint GL_BGR = 0x80E0;
		public const uint GL_BGRA = 0x80E1;
		public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint GL_CLAMP_TO_EDGE = 0x812F;
		public const uint GL_TEXTURE_MIN_LOD = 0x813A;
		public const uint GL_TEXTURE_MAX_LOD = 0x813B;
		public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
		public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
		public const uint GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint GL_RESCALE_NORMAL = 0x803A;
		public const uint GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
		public const uint GL_SINGLE_COLOR = 0x81F9;
		public const uint GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
		public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const uint GL_TEXTURE0 = 0x84C0;
		public const uint GL_TEXTURE1 = 0x84C1;
		public const uint GL_TEXTURE2 = 0x84C2;
		public const uint GL_TEXTURE3 = 0x84C3;
		public const uint GL_TEXTURE4 = 0x84C4;
		public const uint GL_TEXTURE5 = 0x84C5;
		public const uint GL_TEXTURE6 = 0x84C6;
		public const uint GL_TEXTURE7 = 0x84C7;
		public const uint GL_TEXTURE8 = 0x84C8;
		public const uint GL_TEXTURE9 = 0x84C9;
		public const uint GL_TEXTURE10 = 0x84CA;
		public const uint GL_TEXTURE11 = 0x84CB;
		public const uint GL_TEXTURE12 = 0x84CC;
		public const uint GL_TEXTURE13 = 0x84CD;
		public const uint GL_TEXTURE14 = 0x84CE;
		public const uint GL_TEXTURE15 = 0x84CF;
		public const uint GL_TEXTURE16 = 0x84D0;
		public const uint GL_TEXTURE17 = 0x84D1;
		public const uint GL_TEXTURE18 = 0x84D2;
		public const uint GL_TEXTURE19 = 0x84D3;
		public const uint GL_TEXTURE20 = 0x84D4;
		public const uint GL_TEXTURE21 = 0x84D5;
		public const uint GL_TEXTURE22 = 0x84D6;
		public const uint GL_TEXTURE23 = 0x84D7;
		public const uint GL_TEXTURE24 = 0x84D8;
		public const uint GL_TEXTURE25 = 0x84D9;
		public const uint GL_TEXTURE26 = 0x84DA;
		public const uint GL_TEXTURE27 = 0x84DB;
		public const uint GL_TEXTURE28 = 0x84DC;
		public const uint GL_TEXTURE29 = 0x84DD;
		public const uint GL_TEXTURE30 = 0x84DE;
		public const uint GL_TEXTURE31 = 0x84DF;
		public const uint GL_ACTIVE_TEXTURE = 0x84E0;
		public const uint GL_MULTISAMPLE = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint GL_SAMPLE_COVERAGE = 0x80A0;
		public const uint GL_SAMPLE_BUFFERS = 0x80A8;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint GL_COMPRESSED_RGB = 0x84ED;
		public const uint GL_COMPRESSED_RGBA = 0x84EE;
		public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint GL_CLAMP_TO_BORDER = 0x812D;
		public const uint GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
		public const uint GL_MAX_TEXTURE_UNITS = 0x84E2;
		public const uint GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
		public const uint GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
		public const uint GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
		public const uint GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
		public const uint GL_MULTISAMPLE_BIT = 0x20000000;
		public const uint GL_NORMAL_MAP = 0x8511;
		public const uint GL_REFLECTION_MAP = 0x8512;
		public const uint GL_COMPRESSED_ALPHA = 0x84E9;
		public const uint GL_COMPRESSED_LUMINANCE = 0x84EA;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
		public const uint GL_COMPRESSED_INTENSITY = 0x84EC;
		public const uint GL_COMBINE = 0x8570;
		public const uint GL_COMBINE_RGB = 0x8571;
		public const uint GL_COMBINE_ALPHA = 0x8572;
		public const uint GL_SOURCE0_RGB = 0x8580;
		public const uint GL_SOURCE1_RGB = 0x8581;
		public const uint GL_SOURCE2_RGB = 0x8582;
		public const uint GL_SOURCE0_ALPHA = 0x8588;
		public const uint GL_SOURCE1_ALPHA = 0x8589;
		public const uint GL_SOURCE2_ALPHA = 0x858A;
		public const uint GL_OPERAND0_RGB = 0x8590;
		public const uint GL_OPERAND1_RGB = 0x8591;
		public const uint GL_OPERAND2_RGB = 0x8592;
		public const uint GL_OPERAND0_ALPHA = 0x8598;
		public const uint GL_OPERAND1_ALPHA = 0x8599;
		public const uint GL_OPERAND2_ALPHA = 0x859A;
		public const uint GL_RGB_SCALE = 0x8573;
		public const uint GL_ADD_SIGNED = 0x8574;
		public const uint GL_INTERPOLATE = 0x8575;
		public const uint GL_SUBTRACT = 0x84E7;
		public const uint GL_CONSTANT = 0x8576;
		public const uint GL_PRIMARY_COLOR = 0x8577;
		public const uint GL_PREVIOUS = 0x8578;
		public const uint GL_DOT3_RGB = 0x86AE;
		public const uint GL_DOT3_RGBA = 0x86AF;
        public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_SRC_RGB = 0x80C9;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24 = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32 = 0x81A7;
		public const uint GL_MIRRORED_REPEAT = 0x8370;
		public const uint GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const uint GL_TEXTURE_LOD_BIAS = 0x8501;
		public const uint GL_INCR_WRAP = 0x8507;
		public const uint GL_DECR_WRAP = 0x8508;
		public const uint GL_TEXTURE_DEPTH_SIZE = 0x884A;
		public const uint GL_TEXTURE_COMPARE_MODE = 0x884C;
		public const uint GL_TEXTURE_COMPARE_FUNC = 0x884D;
		public const uint GL_POINT_SIZE_MIN = 0x8126;
		public const uint GL_POINT_SIZE_MAX = 0x8127;
		public const uint GL_POINT_DISTANCE_ATTENUATION = 0x8129;
		public const uint GL_GENERATE_MIPMAP = 0x8191;
		public const uint GL_GENERATE_MIPMAP_HINT = 0x8192;
		public const uint GL_FOG_COORDINATE_SOURCE = 0x8450;
		public const uint GL_FOG_COORDINATE = 0x8451;
		public const uint GL_FRAGMENT_DEPTH = 0x8452;
		public const uint GL_CURRENT_FOG_COORDINATE = 0x8453;
		public const uint GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
		public const uint GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
		public const uint GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
		public const uint GL_FOG_COORDINATE_ARRAY = 0x8457;
		public const uint GL_COLOR_SUM = 0x8458;
		public const uint GL_CURRENT_SECONDARY_COLOR = 0x8459;
		public const uint GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
		public const uint GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
		public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
		public const uint GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
		public const uint GL_SECONDARY_COLOR_ARRAY = 0x845E;
		public const uint GL_TEXTURE_FILTER_CONTROL = 0x8500;
		public const uint GL_DEPTH_TEXTURE_MODE = 0x884B;
		public const uint GL_COMPARE_R_TO_TEXTURE = 0x884E;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_MIN = 0x8007;
		public const uint GL_MAX = 0x8008;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const uint GL_BUFFER_SIZE = 0x8764;
		public const uint GL_BUFFER_USAGE = 0x8765;
		public const uint GL_QUERY_COUNTER_BITS = 0x8864;
		public const uint GL_CURRENT_QUERY = 0x8865;
		public const uint GL_QUERY_RESULT = 0x8866;
		public const uint GL_QUERY_RESULT_AVAILABLE = 0x8867;
		public const uint GL_ARRAY_BUFFER = 0x8892;
		public const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint GL_READ_ONLY = 0x88B8;
		public const uint GL_WRITE_ONLY = 0x88B9;
		public const uint GL_READ_WRITE = 0x88BA;
		public const uint GL_BUFFER_ACCESS = 0x88BB;
		public const uint GL_BUFFER_MAPPED = 0x88BC;
		public const uint GL_BUFFER_MAP_POINTER = 0x88BD;
		public const uint GL_STREAM_DRAW = 0x88E0;
		public const uint GL_STREAM_READ = 0x88E1;
		public const uint GL_STREAM_COPY = 0x88E2;
		public const uint GL_STATIC_DRAW = 0x88E4;
		public const uint GL_STATIC_READ = 0x88E5;
		public const uint GL_STATIC_COPY = 0x88E6;
		public const uint GL_DYNAMIC_DRAW = 0x88E8;
		public const uint GL_DYNAMIC_READ = 0x88E9;
		public const uint GL_DYNAMIC_COPY = 0x88EA;
		public const uint GL_SAMPLES_PASSED = 0x8914;
		public const uint GL_SRC1_ALPHA = 0x8589;
		public const uint GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
		public const uint GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
		public const uint GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
		public const uint GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
		public const uint GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
		public const uint GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
		public const uint GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
		public const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
		public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
		public const uint GL_FOG_COORD_SRC = 0x8450;
		public const uint GL_FOG_COORD = 0x8451;
		public const uint GL_CURRENT_FOG_COORD = 0x8453;
		public const uint GL_FOG_COORD_ARRAY_TYPE = 0x8454;
		public const uint GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
		public const uint GL_FOG_COORD_ARRAY_POINTER = 0x8456;
		public const uint GL_FOG_COORD_ARRAY = 0x8457;
		public const uint GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
		public const uint GL_SRC0_RGB = 0x8580;
		public const uint GL_SRC1_RGB = 0x8581;
		public const uint GL_SRC2_RGB = 0x8582;
		public const uint GL_SRC0_ALPHA = 0x8588;
		public const uint GL_SRC2_ALPHA = 0x858A;
        public const uint GL_BLEND_EQUATION_RGB = 0x8009;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint GL_STENCIL_BACK_FUNC = 0x8800;
		public const uint GL_STENCIL_BACK_FAIL = 0x8801;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint GL_MAX_DRAW_BUFFERS = 0x8824;
		public const uint GL_DRAW_BUFFER0 = 0x8825;
		public const uint GL_DRAW_BUFFER1 = 0x8826;
		public const uint GL_DRAW_BUFFER2 = 0x8827;
		public const uint GL_DRAW_BUFFER3 = 0x8828;
		public const uint GL_DRAW_BUFFER4 = 0x8829;
		public const uint GL_DRAW_BUFFER5 = 0x882A;
		public const uint GL_DRAW_BUFFER6 = 0x882B;
		public const uint GL_DRAW_BUFFER7 = 0x882C;
		public const uint GL_DRAW_BUFFER8 = 0x882D;
		public const uint GL_DRAW_BUFFER9 = 0x882E;
		public const uint GL_DRAW_BUFFER10 = 0x882F;
		public const uint GL_DRAW_BUFFER11 = 0x8830;
		public const uint GL_DRAW_BUFFER12 = 0x8831;
		public const uint GL_DRAW_BUFFER13 = 0x8832;
		public const uint GL_DRAW_BUFFER14 = 0x8833;
		public const uint GL_DRAW_BUFFER15 = 0x8834;
		public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const uint GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint GL_FRAGMENT_SHADER = 0x8B30;
		public const uint GL_VERTEX_SHADER = 0x8B31;
		public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const uint GL_MAX_VARYING_FLOATS = 0x8B4B;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint GL_SHADER_TYPE = 0x8B4F;
		public const uint GL_FLOAT_VEC2 = 0x8B50;
		public const uint GL_FLOAT_VEC3 = 0x8B51;
		public const uint GL_FLOAT_VEC4 = 0x8B52;
		public const uint GL_INT_VEC2 = 0x8B53;
		public const uint GL_INT_VEC3 = 0x8B54;
		public const uint GL_INT_VEC4 = 0x8B55;
		public const uint GL_BOOL = 0x8B56;
		public const uint GL_BOOL_VEC2 = 0x8B57;
		public const uint GL_BOOL_VEC3 = 0x8B58;
		public const uint GL_BOOL_VEC4 = 0x8B59;
		public const uint GL_FLOAT_MAT2 = 0x8B5A;
		public const uint GL_FLOAT_MAT3 = 0x8B5B;
		public const uint GL_FLOAT_MAT4 = 0x8B5C;
		public const uint GL_SAMPLER_1D = 0x8B5D;
		public const uint GL_SAMPLER_2D = 0x8B5E;
		public const uint GL_SAMPLER_3D = 0x8B5F;
		public const uint GL_SAMPLER_CUBE = 0x8B60;
		public const uint GL_SAMPLER_1D_SHADOW = 0x8B61;
		public const uint GL_SAMPLER_2D_SHADOW = 0x8B62;
		public const uint GL_DELETE_STATUS = 0x8B80;
		public const uint GL_COMPILE_STATUS = 0x8B81;
		public const uint GL_LINK_STATUS = 0x8B82;
		public const uint GL_VALIDATE_STATUS = 0x8B83;
		public const uint GL_INFO_LOG_LENGTH = 0x8B84;
		public const uint GL_ATTACHED_SHADERS = 0x8B85;
		public const uint GL_ACTIVE_UNIFORMS = 0x8B86;
		public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint GL_CURRENT_PROGRAM = 0x8B8D;
		public const uint GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const uint GL_LOWER_LEFT = 0x8CA1;
		public const uint GL_UPPER_LEFT = 0x8CA2;
		public const uint GL_STENCIL_BACK_REF = 0x8CA3;
		public const uint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
		public const uint GL_POINT_SPRITE = 0x8861;
		public const uint GL_COORD_REPLACE = 0x8862;
		public const uint GL_MAX_TEXTURE_COORDS = 0x8871;
        public const uint GL_PIXEL_PACK_BUFFER = 0x88EB;
		public const uint GL_PIXEL_UNPACK_BUFFER = 0x88EC;
		public const uint GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const uint GL_FLOAT_MAT2x3 = 0x8B65;
		public const uint GL_FLOAT_MAT2x4 = 0x8B66;
		public const uint GL_FLOAT_MAT3x2 = 0x8B67;
		public const uint GL_FLOAT_MAT3x4 = 0x8B68;
		public const uint GL_FLOAT_MAT4x2 = 0x8B69;
		public const uint GL_FLOAT_MAT4x3 = 0x8B6A;
		public const uint GL_SRGB = 0x8C40;
		public const uint GL_SRGB8 = 0x8C41;
		public const uint GL_SRGB_ALPHA = 0x8C42;
		public const uint GL_SRGB8_ALPHA8 = 0x8C43;
		public const uint GL_COMPRESSED_SRGB = 0x8C48;
		public const uint GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const uint GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
		public const uint GL_SLUMINANCE_ALPHA = 0x8C44;
		public const uint GL_SLUMINANCE8_ALPHA8 = 0x8C45;
		public const uint GL_SLUMINANCE = 0x8C46;
		public const uint GL_SLUMINANCE8 = 0x8C47;
		public const uint GL_COMPRESSED_SLUMINANCE = 0x8C4A;
		public const uint GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        public const uint GL_COMPARE_REF_TO_TEXTURE = 0x884E;
		public const uint GL_CLIP_DISTANCE0 = 0x3000;
		public const uint GL_CLIP_DISTANCE1 = 0x3001;
		public const uint GL_CLIP_DISTANCE2 = 0x3002;
		public const uint GL_CLIP_DISTANCE3 = 0x3003;
		public const uint GL_CLIP_DISTANCE4 = 0x3004;
		public const uint GL_CLIP_DISTANCE5 = 0x3005;
		public const uint GL_CLIP_DISTANCE6 = 0x3006;
		public const uint GL_CLIP_DISTANCE7 = 0x3007;
		public const uint GL_MAX_CLIP_DISTANCES = 0x0D32;
		public const uint GL_MAJOR_VERSION = 0x821B;
		public const uint GL_MINOR_VERSION = 0x821C;
		public const uint GL_NUM_EXTENSIONS = 0x821D;
		public const uint GL_CONTEXT_FLAGS = 0x821E;
		public const uint GL_COMPRESSED_RED = 0x8225;
		public const uint GL_COMPRESSED_RG = 0x8226;
		public const uint GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint GL_RGBA32F = 0x8814;
		public const uint GL_RGB32F = 0x8815;
		public const uint GL_RGBA16F = 0x881A;
		public const uint GL_RGB16F = 0x881B;
		public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const uint GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const uint GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const uint GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const uint GL_CLAMP_READ_COLOR = 0x891C;
		public const uint GL_FIXED_ONLY = 0x891D;
		public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const uint GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const uint GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint GL_R11F_G11F_B10F = 0x8C3A;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint GL_RGB9_E5 = 0x8C3D;
		public const uint GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const uint GL_TEXTURE_SHARED_SIZE = 0x8C3F;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const uint GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const uint GL_PRIMITIVES_GENERATED = 0x8C87;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint GL_RASTERIZER_DISCARD = 0x8C89;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const uint GL_INTERLEAVED_ATTRIBS = 0x8C8C;
		public const uint GL_SEPARATE_ATTRIBS = 0x8C8D;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const uint GL_RGBA32UI = 0x8D70;
		public const uint GL_RGB32UI = 0x8D71;
		public const uint GL_RGBA16UI = 0x8D76;
		public const uint GL_RGB16UI = 0x8D77;
		public const uint GL_RGBA8UI = 0x8D7C;
		public const uint GL_RGB8UI = 0x8D7D;
		public const uint GL_RGBA32I = 0x8D82;
		public const uint GL_RGB32I = 0x8D83;
		public const uint GL_RGBA16I = 0x8D88;
		public const uint GL_RGB16I = 0x8D89;
		public const uint GL_RGBA8I = 0x8D8E;
		public const uint GL_RGB8I = 0x8D8F;
		public const uint GL_RED_INTEGER = 0x8D94;
		public const uint GL_GREEN_INTEGER = 0x8D95;
		public const uint GL_BLUE_INTEGER = 0x8D96;
		public const uint GL_RGB_INTEGER = 0x8D98;
		public const uint GL_RGBA_INTEGER = 0x8D99;
		public const uint GL_BGR_INTEGER = 0x8D9A;
		public const uint GL_BGRA_INTEGER = 0x8D9B;
		public const uint GL_SAMPLER_1D_ARRAY = 0x8DC0;
		public const uint GL_SAMPLER_2D_ARRAY = 0x8DC1;
		public const uint GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const uint GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const uint GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const uint GL_UNSIGNED_INT_VEC2 = 0x8DC6;
		public const uint GL_UNSIGNED_INT_VEC3 = 0x8DC7;
		public const uint GL_UNSIGNED_INT_VEC4 = 0x8DC8;
		public const uint GL_INT_SAMPLER_1D = 0x8DC9;
		public const uint GL_INT_SAMPLER_2D = 0x8DCA;
		public const uint GL_INT_SAMPLER_3D = 0x8DCB;
		public const uint GL_INT_SAMPLER_CUBE = 0x8DCC;
		public const uint GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const uint GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const uint GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const uint GL_QUERY_WAIT = 0x8E13;
		public const uint GL_QUERY_NO_WAIT = 0x8E14;
		public const uint GL_QUERY_BY_REGION_WAIT = 0x8E15;
		public const uint GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const uint GL_BUFFER_ACCESS_FLAGS = 0x911F;
		public const uint GL_BUFFER_MAP_LENGTH = 0x9120;
		public const uint GL_BUFFER_MAP_OFFSET = 0x9121;
		public const uint GL_DEPTH_COMPONENT32F = 0x8CAC;
		public const uint GL_DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint GL_DEPTH_STENCIL = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const uint GL_DEPTH24_STENCIL8 = 0x88F0;
		public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint GL_TEXTURE_RED_TYPE = 0x8C10;
		public const uint GL_TEXTURE_GREEN_TYPE = 0x8C11;
		public const uint GL_TEXTURE_BLUE_TYPE = 0x8C12;
		public const uint GL_TEXTURE_ALPHA_TYPE = 0x8C13;
		public const uint GL_TEXTURE_DEPTH_TYPE = 0x8C16;
		public const uint GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const uint GL_READ_FRAMEBUFFER = 0x8CA8;
		public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const uint GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const uint GL_COLOR_ATTACHMENT16 = 0x8CF0;
		public const uint GL_COLOR_ATTACHMENT17 = 0x8CF1;
		public const uint GL_COLOR_ATTACHMENT18 = 0x8CF2;
		public const uint GL_COLOR_ATTACHMENT19 = 0x8CF3;
		public const uint GL_COLOR_ATTACHMENT20 = 0x8CF4;
		public const uint GL_COLOR_ATTACHMENT21 = 0x8CF5;
		public const uint GL_COLOR_ATTACHMENT22 = 0x8CF6;
		public const uint GL_COLOR_ATTACHMENT23 = 0x8CF7;
		public const uint GL_COLOR_ATTACHMENT24 = 0x8CF8;
		public const uint GL_COLOR_ATTACHMENT25 = 0x8CF9;
		public const uint GL_COLOR_ATTACHMENT26 = 0x8CFA;
		public const uint GL_COLOR_ATTACHMENT27 = 0x8CFB;
		public const uint GL_COLOR_ATTACHMENT28 = 0x8CFC;
		public const uint GL_COLOR_ATTACHMENT29 = 0x8CFD;
		public const uint GL_COLOR_ATTACHMENT30 = 0x8CFE;
		public const uint GL_COLOR_ATTACHMENT31 = 0x8CFF;
		public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
		public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
		public const uint GL_FRAMEBUFFER = 0x8D40;
		public const uint GL_RENDERBUFFER = 0x8D41;
		public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint GL_STENCIL_INDEX1 = 0x8D46;
		public const uint GL_STENCIL_INDEX4 = 0x8D47;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_STENCIL_INDEX16 = 0x8D49;
		public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint GL_MAX_SAMPLES = 0x8D57;
		public const uint GL_INDEX = 0x8222;
		public const uint GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
		public const uint GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
		public const uint GL_FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint GL_HALF_FLOAT = 0x140B;
		public const uint GL_MAP_READ_BIT = 0x0001;
		public const uint GL_MAP_WRITE_BIT = 0x0002;
		public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint GL_RG = 0x8227;
		public const uint GL_RG_INTEGER = 0x8228;
		public const uint GL_R8 = 0x8229;
		public const uint GL_R16 = 0x822A;
		public const uint GL_RG8 = 0x822B;
		public const uint GL_RG16 = 0x822C;
		public const uint GL_R16F = 0x822D;
		public const uint GL_R32F = 0x822E;
		public const uint GL_RG16F = 0x822F;
		public const uint GL_RG32F = 0x8230;
		public const uint GL_R8I = 0x8231;
		public const uint GL_R8UI = 0x8232;
		public const uint GL_R16I = 0x8233;
		public const uint GL_R16UI = 0x8234;
		public const uint GL_R32I = 0x8235;
		public const uint GL_R32UI = 0x8236;
		public const uint GL_RG8I = 0x8237;
		public const uint GL_RG8UI = 0x8238;
		public const uint GL_RG16I = 0x8239;
		public const uint GL_RG16UI = 0x823A;
		public const uint GL_RG32I = 0x823B;
		public const uint GL_RG32UI = 0x823C;
		public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint GL_CLAMP_VERTEX_COLOR = 0x891A;
		public const uint GL_CLAMP_FRAGMENT_COLOR = 0x891B;
		public const uint GL_ALPHA_INTEGER = 0x8D97;
        public const uint GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint GL_LINES_ADJACENCY = 0x000A;
		public const uint GL_LINE_STRIP_ADJACENCY = 0x000B;
		public const uint GL_TRIANGLES_ADJACENCY = 0x000C;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const uint GL_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const uint GL_GEOMETRY_SHADER = 0x8DD9;
		public const uint GL_GEOMETRY_VERTICES_OUT = 0x8916;
		public const uint GL_GEOMETRY_INPUT_TYPE = 0x8917;
		public const uint GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const uint GL_CONTEXT_PROFILE_MASK = 0x9126;
		public const uint GL_DEPTH_CLAMP = 0x864F;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint GL_PROVOKING_VERTEX = 0x8E4F;
		public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint GL_OBJECT_TYPE = 0x9112;
		public const uint GL_SYNC_CONDITION = 0x9113;
		public const uint GL_SYNC_STATUS = 0x9114;
		public const uint GL_SYNC_FLAGS = 0x9115;
		public const uint GL_SYNC_FENCE = 0x9116;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint GL_UNSIGNALED = 0x9118;
		public const uint GL_SIGNALED = 0x9119;
		public const uint GL_ALREADY_SIGNALED = 0x911A;
		public const uint GL_TIMEOUT_EXPIRED = 0x911B;
		public const uint GL_CONDITION_SATISFIED = 0x911C;
		public const uint GL_WAIT_FAILED = 0x911D;
		public const uint GL_TIMEOUT_IGNORED = 0xFFFFFFFF;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint GL_SAMPLE_POSITION = 0x8E50;
		public const uint GL_SAMPLE_MASK = 0x8E51;
		public const uint GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const uint GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint GL_TEXTURE_SAMPLES = 0x9106;
		public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint GL_MAX_INTEGER_SAMPLES = 0x9110;
        public const uint GL_SAMPLER_2D_RECT = 0x8B63;
		public const uint GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const uint GL_SAMPLER_BUFFER = 0x8DC2;
		public const uint GL_INT_SAMPLER_2D_RECT = 0x8DCD;
		public const uint GL_INT_SAMPLER_BUFFER = 0x8DD0;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const uint GL_TEXTURE_BUFFER = 0x8C2A;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const uint GL_TEXTURE_RECTANGLE = 0x84F5;
		public const uint GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const uint GL_R8_SNORM = 0x8F94;
		public const uint GL_RG8_SNORM = 0x8F95;
		public const uint GL_RGB8_SNORM = 0x8F96;
		public const uint GL_RGBA8_SNORM = 0x8F97;
		public const uint GL_R16_SNORM = 0x8F98;
		public const uint GL_RG16_SNORM = 0x8F99;
		public const uint GL_RGB16_SNORM = 0x8F9A;
		public const uint GL_RGBA16_SNORM = 0x8F9B;
		public const uint GL_SIGNED_NORMALIZED = 0x8F9C;
		public const uint GL_PRIMITIVE_RESTART = 0x8F9D;
		public const uint GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const uint GL_COPY_READ_BUFFER = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER = 0x8F37;
		public const uint GL_UNIFORM_BUFFER = 0x8A11;
		public const uint GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint GL_UNIFORM_BUFFER_START = 0x8A29;
		public const uint GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint GL_UNIFORM_TYPE = 0x8A37;
		public const uint GL_UNIFORM_SIZE = 0x8A38;
		public const uint GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint GL_UNIFORM_OFFSET = 0x8A3B;
		public const uint GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint GL_INVALID_INDEX = 0xFFFFFFFF;
        public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const uint GL_SRC1_COLOR = 0x88F9;
		public const uint GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint GL_ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint GL_SAMPLER_BINDING = 0x8919;
		public const uint GL_RGB10_A2UI = 0x906F;
		public const uint GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint GL_TIME_ELAPSED = 0x88BF;
		public const uint GL_TIMESTAMP = 0x8E28;
		public const uint GL_INT_2_10_10_10_REV = 0x8D9F;
        public const uint GL_SAMPLE_SHADING = 0x8C36;
		public const uint GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const uint GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint GL_MAX_VERTEX_STREAMS = 0x8E71;
		public const uint GL_DOUBLE_VEC2 = 0x8FFC;
		public const uint GL_DOUBLE_VEC3 = 0x8FFD;
		public const uint GL_DOUBLE_VEC4 = 0x8FFE;
		public const uint GL_DOUBLE_MAT2 = 0x8F46;
		public const uint GL_DOUBLE_MAT3 = 0x8F47;
		public const uint GL_DOUBLE_MAT4 = 0x8F48;
		public const uint GL_DOUBLE_MAT2x3 = 0x8F49;
		public const uint GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const uint GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const uint GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const uint GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const uint GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const uint GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint GL_MAX_SUBROUTINES = 0x8DE7;
		public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint GL_PATCHES = 0x000E;
		public const uint GL_PATCH_VERTICES = 0x8E72;
		public const uint GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint GL_TESS_GEN_MODE = 0x8E76;
		public const uint GL_TESS_GEN_SPACING = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const uint GL_ISOLINES = 0x8E7A;
		public const uint GL_FRACTIONAL_ODD = 0x8E7B;
		public const uint GL_FRACTIONAL_EVEN = 0x8E7C;
		public const uint GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const uint GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const uint GL_TESS_CONTROL_SHADER = 0x8E88;
		public const uint GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const uint GL_FIXED = 0x140C;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint GL_LOW_FLOAT = 0x8DF0;
		public const uint GL_MEDIUM_FLOAT = 0x8DF1;
		public const uint GL_HIGH_FLOAT = 0x8DF2;
		public const uint GL_LOW_INT = 0x8DF3;
		public const uint GL_MEDIUM_INT = 0x8DF4;
		public const uint GL_HIGH_INT = 0x8DF5;
		public const uint GL_SHADER_COMPILER = 0x8DFA;
		public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint GL_RGB565 = 0x8D62;
		public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint GL_PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint GL_VERTEX_SHADER_BIT = 0x00000001;
		public const uint GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint GL_PROGRAM_SEPARABLE = 0x8258;
		public const uint GL_ACTIVE_PROGRAM = 0x8259;
		public const uint GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint GL_MAX_VIEWPORTS = 0x825B;
		public const uint GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint GL_UNDEFINED_VERTEX = 0x8260;
        public const uint GL_COPY_READ_BUFFER_BINDING = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint GL_NUM_SAMPLE_COUNTS = 0x9380;
		public const uint GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint GL_UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint GL_COMMAND_BARRIER_BIT = 0x00000040;
		public const uint GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint GL_MAX_IMAGE_UNITS = 0x8F38;
		public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint GL_IMAGE_BINDING_NAME = 0x8F3A;
		public const uint GL_IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint GL_IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint GL_IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint GL_IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint GL_IMAGE_1D = 0x904C;
		public const uint GL_IMAGE_2D = 0x904D;
		public const uint GL_IMAGE_3D = 0x904E;
		public const uint GL_IMAGE_2D_RECT = 0x904F;
		public const uint GL_IMAGE_CUBE = 0x9050;
		public const uint GL_IMAGE_BUFFER = 0x9051;
		public const uint GL_IMAGE_1D_ARRAY = 0x9052;
		public const uint GL_IMAGE_2D_ARRAY = 0x9053;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint GL_IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint GL_INT_IMAGE_1D = 0x9057;
		public const uint GL_INT_IMAGE_2D = 0x9058;
		public const uint GL_INT_IMAGE_3D = 0x9059;
		public const uint GL_INT_IMAGE_2D_RECT = 0x905A;
		public const uint GL_INT_IMAGE_CUBE = 0x905B;
		public const uint GL_INT_IMAGE_BUFFER = 0x905C;
		public const uint GL_INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint GL_INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint GL_MAX_IMAGE_SAMPLES = 0x906D;
		public const uint GL_IMAGE_BINDING_FORMAT = 0x906E;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
		public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
		public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
		public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
		public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const uint GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const uint GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const uint GL_COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint GL_COMPRESSED_R11_EAC = 0x9270;
		public const uint GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint GL_COMPRESSED_RG11_EAC = 0x9272;
		public const uint GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint GL_MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint GL_COMPUTE_SHADER = 0x91B9;
		public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint GL_DEBUG_SOURCE_API = 0x8246;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint GL_DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER = 0x824B;
		public const uint GL_DEBUG_TYPE_ERROR = 0x824C;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint GL_DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint GL_DEBUG_TYPE_OTHER = 0x8251;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint GL_DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint GL_DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint GL_DEBUG_SEVERITY_LOW = 0x9148;
		public const uint GL_DEBUG_TYPE_MARKER = 0x8268;
		public const uint GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint GL_DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint GL_BUFFER = 0x82E0;
		public const uint GL_SHADER = 0x82E1;
		public const uint GL_PROGRAM = 0x82E2;
		public const uint GL_QUERY = 0x82E3;
		public const uint GL_PROGRAM_PIPELINE = 0x82E4;
		public const uint GL_SAMPLER = 0x82E6;
		public const uint GL_MAX_LABEL_LENGTH = 0x82E8;
		public const uint GL_DEBUG_OUTPUT = 0x92E0;
		public const uint GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint GL_MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint GL_INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint GL_INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint GL_INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint GL_INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint GL_MAX_WIDTH = 0x827E;
		public const uint GL_MAX_HEIGHT = 0x827F;
		public const uint GL_MAX_DEPTH = 0x8280;
		public const uint GL_MAX_LAYERS = 0x8281;
		public const uint GL_MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint GL_COLOR_COMPONENTS = 0x8283;
		public const uint GL_DEPTH_COMPONENTS = 0x8284;
		public const uint GL_STENCIL_COMPONENTS = 0x8285;
		public const uint GL_COLOR_RENDERABLE = 0x8286;
		public const uint GL_DEPTH_RENDERABLE = 0x8287;
		public const uint GL_STENCIL_RENDERABLE = 0x8288;
		public const uint GL_FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint GL_FRAMEBUFFER_BLEND = 0x828B;
		public const uint GL_READ_PIXELS = 0x828C;
		public const uint GL_READ_PIXELS_FORMAT = 0x828D;
		public const uint GL_READ_PIXELS_TYPE = 0x828E;
		public const uint GL_TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint GL_TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint GL_MIPMAP = 0x8293;
		public const uint GL_MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint GL_AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint GL_COLOR_ENCODING = 0x8296;
		public const uint GL_SRGB_READ = 0x8297;
		public const uint GL_SRGB_WRITE = 0x8298;
		public const uint GL_FILTER = 0x829A;
		public const uint GL_VERTEX_TEXTURE = 0x829B;
		public const uint GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const uint GL_TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint GL_GEOMETRY_TEXTURE = 0x829E;
		public const uint GL_FRAGMENT_TEXTURE = 0x829F;
		public const uint GL_COMPUTE_TEXTURE = 0x82A0;
		public const uint GL_TEXTURE_SHADOW = 0x82A1;
		public const uint GL_TEXTURE_GATHER = 0x82A2;
		public const uint GL_TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint GL_SHADER_IMAGE_LOAD = 0x82A4;
		public const uint GL_SHADER_IMAGE_STORE = 0x82A5;
		public const uint GL_SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint GL_IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint GL_IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint GL_IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint GL_CLEAR_BUFFER = 0x82B4;
		public const uint GL_TEXTURE_VIEW = 0x82B5;
		public const uint GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint GL_FULL_SUPPORT = 0x82B7;
		public const uint GL_CAVEAT_SUPPORT = 0x82B8;
		public const uint GL_IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint GL_IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint GL_IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint GL_IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint GL_IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint GL_IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint GL_IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint GL_IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint GL_IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint GL_IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint GL_VIEW_CLASS_128_BITS = 0x82C4;
		public const uint GL_VIEW_CLASS_96_BITS = 0x82C5;
		public const uint GL_VIEW_CLASS_64_BITS = 0x82C6;
		public const uint GL_VIEW_CLASS_48_BITS = 0x82C7;
		public const uint GL_VIEW_CLASS_32_BITS = 0x82C8;
		public const uint GL_VIEW_CLASS_24_BITS = 0x82C9;
		public const uint GL_VIEW_CLASS_16_BITS = 0x82CA;
		public const uint GL_VIEW_CLASS_8_BITS = 0x82CB;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint GL_UNIFORM = 0x92E1;
		public const uint GL_UNIFORM_BLOCK = 0x92E2;
		public const uint GL_PROGRAM_INPUT = 0x92E3;
		public const uint GL_PROGRAM_OUTPUT = 0x92E4;
		public const uint GL_BUFFER_VARIABLE = 0x92E5;
		public const uint GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint GL_VERTEX_SUBROUTINE = 0x92E8;
		public const uint GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const uint GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint GL_ACTIVE_RESOURCES = 0x92F5;
		public const uint GL_MAX_NAME_LENGTH = 0x92F6;
		public const uint GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint GL_NAME_LENGTH = 0x92F9;
		public const uint GL_TYPE = 0x92FA;
		public const uint GL_ARRAY_SIZE = 0x92FB;
		public const uint GL_OFFSET = 0x92FC;
		public const uint GL_BLOCK_INDEX = 0x92FD;
		public const uint GL_ARRAY_STRIDE = 0x92FE;
		public const uint GL_MATRIX_STRIDE = 0x92FF;
		public const uint GL_IS_ROW_MAJOR = 0x9300;
		public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint GL_BUFFER_BINDING = 0x9302;
		public const uint GL_BUFFER_DATA_SIZE = 0x9303;
		public const uint GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint GL_ACTIVE_VARIABLES = 0x9305;
		public const uint GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint GL_LOCATION = 0x930E;
		public const uint GL_LOCATION_INDEX = 0x930F;
		public const uint GL_IS_PER_PATCH = 0x92E7;
		public const uint GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint GL_VERTEX_BINDING_BUFFER = 0x8F4F;
		public const uint GL_DISPLAY_LIST = 0x82E7;
        public const uint GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const uint GL_MAP_PERSISTENT_BIT = 0x0040;
		public const uint GL_MAP_COHERENT_BIT = 0x0080;
		public const uint GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint GL_CLIENT_STORAGE_BIT = 0x0200;
		public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint GL_BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint GL_CLEAR_TEXTURE = 0x9365;
		public const uint GL_LOCATION_COMPONENT = 0x934A;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint GL_QUERY_BUFFER = 0x9192;
		public const uint GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint GL_QUERY_BUFFER_BINDING = 0x9193;
		public const uint GL_QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
        public const uint GL_CONTEXT_LOST = 0x0507;
		public const uint GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint GL_ZERO_TO_ONE = 0x935F;
		public const uint GL_CLIP_ORIGIN = 0x935C;
		public const uint GL_CLIP_DEPTH_MODE = 0x935D;
		public const uint GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const uint GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint GL_MAX_CULL_DISTANCES = 0x82F9;
		public const uint GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint GL_TEXTURE_TARGET = 0x1006;
		public const uint GL_QUERY_TARGET = 0x82EA;
		public const uint GL_GUILTY_CONTEXT_RESET = 0x8253;
		public const uint GL_INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint GL_UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint GL_LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint GL_NO_RESET_NOTIFICATION = 0x8261;
		public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

        #endregion

        #region Delegates
		
		private delegate void glDrawRangeElementsDelegate(uint mode, uint start, uint end, int count, uint type, nint indices);
		private delegate void glTexImage3DDelegate(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels);
		private delegate void glTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCopyTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        private delegate void glActiveTextureDelegate(uint texture);
		private delegate void glSampleCoverageDelegate(float value, bool invert);
		private delegate void glCompressedTexImage3DDelegate(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data);
		private delegate void glCompressedTexImage2DDelegate(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint data);
		private delegate void glCompressedTexImage1DDelegate(uint target, int level, uint internalformat, int width, int border, int imageSize, nint data);
		private delegate void glCompressedTexSubImage3DDelegate(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data);
		private delegate void glCompressedTexSubImage2DDelegate(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data);
		private delegate void glCompressedTexSubImage1DDelegate(uint target, int level, int xoffset, int width, uint format, int imageSize, nint data);
		private delegate void glGetCompressedTexImageDelegate(uint target, int level, nint img);
		private delegate void glClientActiveTextureDelegate(uint texture);
		private delegate void glMultiTexCoord1dDelegate(uint target, double s);
		private delegate void glMultiTexCoord1dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord1fDelegate(uint target, float s);
		private delegate void glMultiTexCoord1fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord1iDelegate(uint target, int s);
		private delegate void glMultiTexCoord1ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord1sDelegate(uint target, short s);
		private delegate void glMultiTexCoord1svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord2dDelegate(uint target, double s, double t);
		private delegate void glMultiTexCoord2dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord2fDelegate(uint target, float s, float t);
		private delegate void glMultiTexCoord2fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord2iDelegate(uint target, int s, int t);
		private delegate void glMultiTexCoord2ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord2sDelegate(uint target, short s, short t);
		private delegate void glMultiTexCoord2svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord3dDelegate(uint target, double s, double t, double r);
		private delegate void glMultiTexCoord3dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord3fDelegate(uint target, float s, float t, float r);
		private delegate void glMultiTexCoord3fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord3iDelegate(uint target, int s, int t, int r);
		private delegate void glMultiTexCoord3ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord3sDelegate(uint target, short s, short t, short r);
		private delegate void glMultiTexCoord3svDelegate(uint target, short[] v);
		private delegate void glMultiTexCoord4dDelegate(uint target, double s, double t, double r, double q);
		private delegate void glMultiTexCoord4dvDelegate(uint target, double[] v);
		private delegate void glMultiTexCoord4fDelegate(uint target, float s, float t, float r, float q);
		private delegate void glMultiTexCoord4fvDelegate(uint target, float[] v);
		private delegate void glMultiTexCoord4iDelegate(uint target, int s, int t, int r, int q);
		private delegate void glMultiTexCoord4ivDelegate(uint target, int[] v);
		private delegate void glMultiTexCoord4sDelegate(uint target, short s, short t, short r, short q);
		private delegate void glMultiTexCoord4svDelegate(uint target, short[] v);
		private delegate void glLoadTransposeMatrixfDelegate(float[] m);
		private delegate void glLoadTransposeMatrixdDelegate(double[] m);
		private delegate void glMultTransposeMatrixfDelegate(float[] m);
		private delegate void glMultTransposeMatrixdDelegate(double[] m);
        private delegate void glBlendFuncSeparateDelegate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		private delegate void glMultiDrawArraysDelegate(uint mode, int[] first, int[] count, int drawcount);
		private delegate void glMultiDrawElementsDelegate(uint mode, int[] count, uint type, nint indices, int drawcount);
		private delegate void glPointParameterfDelegate(uint pname, float param);
		private delegate void glPointParameterfvDelegate(uint pname, float[] @params);
		private delegate void glPointParameteriDelegate(uint pname, int param);
		private delegate void glPointParameterivDelegate(uint pname, int[] @params);
		private delegate void glFogCoordfDelegate(float coord);
		private delegate void glFogCoordfvDelegate(float[] coord);
		private delegate void glFogCoorddDelegate(double coord);
		private delegate void glFogCoorddvDelegate(double[] coord);
		private delegate void glFogCoordPointerDelegate(uint type, int stride, nint pointer);
		private delegate void glSecondaryColor3bDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3bvDelegate(byte[] v);
		private delegate void glSecondaryColor3dDelegate(double red, double green, double blue);
		private delegate void glSecondaryColor3dvDelegate(double[] v);
		private delegate void glSecondaryColor3fDelegate(float red, float green, float blue);
		private delegate void glSecondaryColor3fvDelegate(float[] v);
		private delegate void glSecondaryColor3iDelegate(int red, int green, int blue);
		private delegate void glSecondaryColor3ivDelegate(int[] v);
		private delegate void glSecondaryColor3sDelegate(short red, short green, short blue);
		private delegate void glSecondaryColor3svDelegate(short[] v);
		private delegate void glSecondaryColor3ubDelegate(byte red, byte green, byte blue);
		private delegate void glSecondaryColor3ubvDelegate(byte[] v);
		private delegate void glSecondaryColor3uiDelegate(uint red, uint green, uint blue);
		private delegate void glSecondaryColor3uivDelegate(uint[] v);
		private delegate void glSecondaryColor3usDelegate(ushort red, ushort green, ushort blue);
		private delegate void glSecondaryColor3usvDelegate(ushort[] v);
		private delegate void glSecondaryColorPointerDelegate(int size, uint type, int stride, nint pointer);
		private delegate void glWindowPos2dDelegate(double x, double y);
		private delegate void glWindowPos2dvDelegate(double[] v);
		private delegate void glWindowPos2fDelegate(float x, float y);
		private delegate void glWindowPos2fvDelegate(float[] v);
		private delegate void glWindowPos2iDelegate(int x, int y);
		private delegate void glWindowPos2ivDelegate(int[] v);
		private delegate void glWindowPos2sDelegate(short x, short y);
		private delegate void glWindowPos2svDelegate(short[] v);
		private delegate void glWindowPos3dDelegate(double x, double y, double z);
		private delegate void glWindowPos3dvDelegate(double[] v);
		private delegate void glWindowPos3fDelegate(float x, float y, float z);
		private delegate void glWindowPos3fvDelegate(float[] v);
		private delegate void glWindowPos3iDelegate(int x, int y, int z);
		private delegate void glWindowPos3ivDelegate(int[] v);
		private delegate void glWindowPos3sDelegate(short x, short y, short z);
		private delegate void glWindowPos3svDelegate(short[] v);
		private delegate void glBlendColorDelegate(float red, float green, float blue, float alpha);
		private delegate void glBlendEquationDelegate(uint mode);
        private delegate void glGenQueriesDelegate(int n, uint[] ids);
		private delegate void glDeleteQueriesDelegate(int n, uint[] ids);
		private delegate bool glIsQueryDelegate(uint id);
		private delegate void glBeginQueryDelegate(uint target, uint id);
		private delegate void glEndQueryDelegate(uint target);
		private delegate void glGetQueryivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetQueryObjectivDelegate(uint id, uint pname, int[] @params);
		private delegate void glGetQueryObjectuivDelegate(uint id, uint pname, uint[] @params);
		private delegate void glBindBufferDelegate(uint target, uint buffer);
		private delegate void glDeleteBuffersDelegate(int n, uint[] buffers);
		private delegate void glGenBuffersDelegate(int n, uint[] buffers);
		private delegate bool glIsBufferDelegate(uint buffer);
		private delegate void glBufferDataFloatDelegate(uint target, int size, float[] data, uint usage);
		private delegate void glBufferDataUintDelegate(uint target, int size, uint[] data, uint usage);
		private delegate void glBufferDataIntDelegate(uint target, int size, int[] data, uint usage);
		private delegate void glBufferDataDoubleDelegate(uint target, int size, double[] data, uint usage);
		private delegate void glBufferSubDataDelegate(uint target, int offset, int size, float[] data);
		private delegate void glGetBufferSubDataDelegate(uint target, nint offset, nint size, nint data);
		private delegate void glMapBufferDelegate(uint target, uint access);
		private delegate bool glUnmapBufferDelegate(uint target);
		private delegate void glGetBufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetBufferPointervDelegate(uint target, uint pname, nint @params);
        private delegate void glBlendEquationSeparateDelegate(uint modeRGB, uint modeAlpha);
		private delegate void glDrawBuffersDelegate(int n, uint[] bufs);
		private delegate void glStencilOpSeparateDelegate(uint face, uint sfail, uint dpfail, uint dppass);
		private delegate void glStencilFuncSeparateDelegate(uint face, uint func, int @ref, uint mask);
		private delegate void glStencilMaskSeparateDelegate(uint face, uint mask);
		private delegate void glAttachShaderDelegate(uint program, uint shader);
		private delegate void glBindAttribLocationDelegate(uint program, uint index, string[] name);
		private delegate void glCompileShaderDelegate(uint shader);
		private delegate uint glCreateProgramDelegate();
		private delegate uint glCreateShaderDelegate(uint type);
		private delegate void glDeleteProgramDelegate(uint program);
		private delegate void glDeleteShaderDelegate(uint shader);
		private delegate void glDetachShaderDelegate(uint program, uint shader);
		private delegate void glDisableVertexAttribArrayDelegate(uint index);
		private delegate void glEnableVertexAttribArrayDelegate(uint index);
		private delegate void glGetActiveAttribDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name);
		private delegate void glGetActiveUniformDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name);
		private delegate void glGetAttachedShadersDelegate(uint program, int maxCount, int[] count, uint[] shaders);
		private delegate uint glGetAttribLocationDelegate(uint program, string name);
		private delegate void glGetProgramivDelegate(uint program, uint pname, ref int @params);
		private delegate void glGetProgramInfoLogDelegate(uint program, int bufSize, ref int length, byte[] infoLog);
		private delegate void glGetShaderivDelegate(uint shader, uint pname, ref int @params);
        private delegate void glGetShaderInfoLogDelegate(uint shader, int bufSize, ref int length, byte[] infoLog);
        private delegate void glGetShaderSourceDelegate(uint shader, int bufSize, int[] length, char[] source);
		private delegate uint glGetUniformLocationDelegate(uint program, string name);
		private delegate void glGetUniformfvDelegate(uint program, uint location, float[] @params);
		private delegate void glGetUniformivDelegate(uint program, uint location, int[] @params);
		private delegate void glGetVertexAttribdvDelegate(uint index, uint pname, double[] @params);
		private delegate void glGetVertexAttribfvDelegate(uint index, uint pname, float[] @params);
		private delegate void glGetVertexAttribivDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribPointervDelegate(uint index, uint pname, nint pointer);
		private delegate bool glIsProgramDelegate(uint program);
		private delegate bool glIsShaderDelegate(uint shader);
		private delegate void glLinkProgramDelegate(uint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall, ThrowOnUnmappableChar = true)]
        private delegate void glShaderSourceDelegate(uint shader, int count, string[] @string, int[] length);
		private delegate void glUseProgramDelegate(uint program);
		private delegate void glUniform1fDelegate(uint location, float v0);
		private delegate void glUniform2fDelegate(uint location, float v0, float v1);
		private delegate void glUniform3fDelegate(uint location, float v0, float v1, float v2);
		private delegate void glUniform4fDelegate(uint location, float v0, float v1, float v2, float v3);
		private delegate void glUniform1iDelegate(uint location, int v0);
		private delegate void glUniform2iDelegate(uint location, int v0, int v1);
		private delegate void glUniform3iDelegate(uint location, int v0, int v1, int v2);
		private delegate void glUniform4iDelegate(uint location, int v0, int v1, int v2, int v3);
		private delegate void glUniform1fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform2fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform3fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform4fvDelegate(uint location, int count, float[] value);
		private delegate void glUniform1ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform2ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform3ivDelegate(uint location, int count, int[] value);
		private delegate void glUniform4ivDelegate(uint location, int count, int[] value);
		private delegate void glUniformMatrix2fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glValidateProgramDelegate(uint program);
		private delegate void glVertexAttrib1dDelegate(uint index, double x);
		private delegate void glVertexAttrib1dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib1fDelegate(uint index, float x);
		private delegate void glVertexAttrib1fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib1sDelegate(uint index, short x);
		private delegate void glVertexAttrib1svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib2dDelegate(uint index, double x, double y);
		private delegate void glVertexAttrib2dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib2fDelegate(uint index, float x, float y);
		private delegate void glVertexAttrib2fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib2sDelegate(uint index, short x, short y);
		private delegate void glVertexAttrib2svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib3dDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttrib3dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib3fDelegate(uint index, float x, float y, float z);
		private delegate void glVertexAttrib3fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib3sDelegate(uint index, short x, short y, short z);
		private delegate void glVertexAttrib3svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NbvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NivDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4NsvDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4NubDelegate(uint index, byte x, byte y, byte z, byte w);
		private delegate void glVertexAttrib4NubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4NuivDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4NusvDelegate(uint index, ushort[] v);
		private delegate void glVertexAttrib4bvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4dDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttrib4dvDelegate(uint index, double[] v);
		private delegate void glVertexAttrib4fDelegate(uint index, float x, float y, float z, float w);
		private delegate void glVertexAttrib4fvDelegate(uint index, float[] v);
		private delegate void glVertexAttrib4ivDelegate(uint index, int[] v);
		private delegate void glVertexAttrib4sDelegate(uint index, short x, short y, short z, short w);
		private delegate void glVertexAttrib4svDelegate(uint index, short[] v);
		private delegate void glVertexAttrib4ubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttrib4uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttrib4usvDelegate(uint index, ushort[] v);
		private delegate void glVertexAttribPointerDelegate(uint index, int size, uint type, bool normalized, int stride, nint pointer);
        private delegate void glReadPixelsDelegate(float x, float y, float width, float height, uint format, uint type, nint pixels);
        private delegate void glUniformMatrix2x3fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x2fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix2x4fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x2fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix3x4fvDelegate(uint location, int count, bool transpose, float[] value);
		private delegate void glUniformMatrix4x3fvDelegate(uint location, int count, bool transpose, float[] value);
        private delegate void glColorMaskiDelegate(uint index, bool r, bool g, bool b, bool a);
		private delegate void glGetBooleani_vDelegate(uint target, uint index, bool[] data);
		private delegate void glGetIntegeri_vDelegate(uint target, uint index, int[] data);
		private delegate void glEnableiDelegate(uint target, uint index);
		private delegate void glDisableiDelegate(uint target, uint index);
		private delegate bool glIsEnablediDelegate(uint target, uint index);
		private delegate void glBeginTransformFeedbackDelegate(uint primitiveMode);
		private delegate void glEndTransformFeedbackDelegate();
		private delegate void glBindBufferRangeDelegate(uint target, uint index, uint buffer, nint offset, nint size);
		private delegate void glBindBufferBaseDelegate(uint target, uint index, uint buffer);
		private delegate void glTransformFeedbackVaryingsDelegate(uint program, int count, char[] varyings, uint bufferMode);
		private delegate void glGetTransformFeedbackVaryingDelegate(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name);
		private delegate void glClampColorDelegate(uint target, uint clamp);
		private delegate void glBeginConditionalRenderDelegate(uint id, uint mode);
		private delegate void glEndConditionalRenderDelegate();
		private delegate void glVertexAttribIPointerDelegate(uint index, int size, uint type, int stride, nint pointer);
		private delegate void glGetVertexAttribIivDelegate(uint index, uint pname, int[] @params);
		private delegate void glGetVertexAttribIuivDelegate(uint index, uint pname, uint[] @params);
		private delegate void glVertexAttribI1iDelegate(uint index, int x);
		private delegate void glVertexAttribI2iDelegate(uint index, int x, int y);
		private delegate void glVertexAttribI3iDelegate(uint index, int x, int y, int z);
		private delegate void glVertexAttribI4iDelegate(uint index, int x, int y, int z, int w);
		private delegate void glVertexAttribI1uiDelegate(uint index, uint x);
		private delegate void glVertexAttribI2uiDelegate(uint index, uint x, uint y);
		private delegate void glVertexAttribI3uiDelegate(uint index, uint x, uint y, uint z);
		private delegate void glVertexAttribI4uiDelegate(uint index, uint x, uint y, uint z, uint w);
		private delegate void glVertexAttribI1ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI2ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI3ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI4ivDelegate(uint index, int[] v);
		private delegate void glVertexAttribI1uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI2uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI3uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4uivDelegate(uint index, uint[] v);
		private delegate void glVertexAttribI4bvDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4svDelegate(uint index, short[] v);
		private delegate void glVertexAttribI4ubvDelegate(uint index, byte[] v);
		private delegate void glVertexAttribI4usvDelegate(uint index, ushort[] v);
		private delegate void glGetUniformuivDelegate(uint program, uint location, uint[] @params);
		private delegate void glBindFragDataLocationDelegate(uint program, uint color, char[] name);
		private delegate int glGetFragDataLocationDelegate(uint program, char[] name);
		private delegate void glUniform1uiDelegate(uint location, uint v0);
		private delegate void glUniform2uiDelegate(uint location, uint v0, uint v1);
		private delegate void glUniform3uiDelegate(uint location, uint v0, uint v1, uint v2);
		private delegate void glUniform4uiDelegate(uint location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glUniform1uivDelegate(uint location, int count, uint[] value);
		private delegate void glUniform2uivDelegate(uint location, int count, uint[] value);
		private delegate void glUniform3uivDelegate(uint location, int count, uint[] value);
		private delegate void glUniform4uivDelegate(uint location, int count, uint[] value);
		private delegate void glTexParameterIivDelegate(uint target, uint pname, int[] @params);
		private delegate void glTexParameterIuivDelegate(uint target, uint pname, uint[] @params);
		private delegate void glGetTexParameterIivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetTexParameterIuivDelegate(uint target, uint pname, uint[] @params);
		private delegate void glClearBufferivDelegate(uint buffer, int drawbuffer, int[] value);
		private delegate void glClearBufferuivDelegate(uint buffer, int drawbuffer, uint[] value);
		private delegate void glClearBufferfvDelegate(uint buffer, int drawbuffer, float[] value);
		private delegate void glClearBufferfiDelegate(uint buffer, int drawbuffer, float depth, int stencil);
		private delegate bool glIsRenderbufferDelegate(uint renderbuffer);
		private delegate void glBindRenderbufferDelegate(uint target, uint renderbuffer);
		private delegate void glDeleteRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glGenRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glRenderbufferStorageDelegate(uint target, uint internalformat, int width, int height);
		private delegate void glGetRenderbufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate bool glIsFramebufferDelegate(uint framebuffer);
		private delegate void glBindFramebufferDelegate(uint target, uint framebuffer);
		private delegate void glDeleteFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glGenFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate uint glCheckFramebufferStatusDelegate(uint target);
		private delegate void glFramebufferTexture1DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture2DDelegate(uint target, uint attachment, uint textarget, uint texture, int level);
		private delegate void glFramebufferTexture3DDelegate(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		private delegate void glFramebufferRenderbufferDelegate(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glGetFramebufferAttachmentParameterivDelegate(uint target, uint attachment, uint pname, int[] @params);
		private delegate void glGenerateMipmapDelegate(uint target);
		private delegate void glBlitFramebufferDelegate(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate void glRenderbufferStorageMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height);
		private delegate void glFramebufferTextureLayerDelegate(uint target, uint attachment, uint texture, int level, int layer);
		private delegate void glMapBufferRangeDelegate(uint target, nint offset, nint length, uint access);
		private delegate void glFlushMappedBufferRangeDelegate(uint target, nint offset, nint length);
		private delegate void glBindVertexArrayDelegate(uint array);
		private delegate void glDeleteVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glGenVertexArraysDelegate(int n, uint[] arrays);
		private delegate bool glIsVertexArrayDelegate(uint array);
        private delegate void glDrawElementsBaseVertexDelegate(uint mode, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawRangeElementsBaseVertexDelegate(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex);
		private delegate void glDrawElementsInstancedBaseVertexDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex);
		private delegate void glMultiDrawElementsBaseVertexDelegate(uint mode, int[] count, uint type, nint indices, int drawcount, int[] basevertex);
		private delegate void glProvokingVertexDelegate(uint mode);
		private delegate nint glFenceSyncDelegate(uint condition, uint flags);
		private delegate bool glIsSyncDelegate(nint sync);
		private delegate void glDeleteSyncDelegate(nint sync);
		private delegate uint glClientWaitSyncDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glWaitSyncDelegate(nint sync, uint flags, UInt64 timeout);
		private delegate void glGetInteger64vDelegate(uint pname, Int64[] data);
		private delegate void glGetSyncivDelegate(nint sync, uint pname, int bufSize, int[] length, int[] values);
		private delegate void glGetInteger64i_vDelegate(uint target, uint index, Int64[] data);
		private delegate void glGetBufferParameteri64vDelegate(uint target, uint pname, Int64[] @params);
		private delegate void glFramebufferTextureDelegate(uint target, uint attachment, uint texture, int level);
		private delegate void glTexImage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexImage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glGetMultisamplefvDelegate(uint pname, uint index, float[] val);
		private delegate void glSampleMaskiDelegate(uint maskNumber, uint mask);
        private delegate void glDrawArraysInstancedDelegate(uint mode, int first, int count, int instancecount);
		private delegate void glDrawElementsInstancedDelegate(uint mode, int count, uint type, nint indices, int instancecount);
		private delegate void glTexBufferDelegate(uint target, uint internalformat, uint buffer);
		private delegate void glPrimitiveRestartIndexDelegate(uint index);
		private delegate void glCopyBufferSubDataDelegate(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size);
		private delegate void glGetUniformIndicesDelegate(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices);
		private delegate void glGetActiveUniformsivDelegate(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params);
		private delegate void glGetActiveUniformNameDelegate(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName);
		private delegate uint glGetUniformBlockIndexDelegate(uint program, char[] uniformBlockName);
		private delegate void glGetActiveUniformBlockivDelegate(uint program, uint uniformBlockIndex, uint pname, int[] @params);
		private delegate void glGetActiveUniformBlockNameDelegate(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName);
		private delegate void glUniformBlockBindingDelegate(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        private delegate void glBindFragDataLocationIndexedDelegate(uint program, uint colorNumber, uint index, char[] name);
		private delegate int glGetFragDataIndexDelegate(uint program, char[] name);
		private delegate void glGenSamplersDelegate(int count, uint[] samplers);
		private delegate void glDeleteSamplersDelegate(int count, uint[] samplers);
		private delegate bool glIsSamplerDelegate(uint sampler);
		private delegate void glBindSamplerDelegate(uint unit, uint sampler);
		private delegate void glSamplerParameteriDelegate(uint sampler, uint pname, int param);
		private delegate void glSamplerParameterivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterfDelegate(uint sampler, uint pname, float param);
		private delegate void glSamplerParameterfvDelegate(uint sampler, uint pname, float[] param);
		private delegate void glSamplerParameterIivDelegate(uint sampler, uint pname, int[] param);
		private delegate void glSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] param);
		private delegate void glGetSamplerParameterivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterIivDelegate(uint sampler, uint pname, int[] @params);
		private delegate void glGetSamplerParameterfvDelegate(uint sampler, uint pname, float[] @params);
		private delegate void glGetSamplerParameterIuivDelegate(uint sampler, uint pname, uint[] @params);
		private delegate void glQueryCounterDelegate(uint id, uint target);
		private delegate void glGetQueryObjecti64vDelegate(uint id, uint pname, Int64[] @params);
		private delegate void glGetQueryObjectui64vDelegate(uint id, uint pname, UInt64[] @params);
		private delegate void glVertexAttribDivisorDelegate(uint index, uint divisor);
		private delegate void glVertexAttribP1uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP1uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP2uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP2uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP3uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP3uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexAttribP4uiDelegate(uint index, uint type, bool normalized, uint value);
		private delegate void glVertexAttribP4uivDelegate(uint index, uint type, bool normalized, uint[] value);
		private delegate void glVertexP2uiDelegate(uint type, uint value);
		private delegate void glVertexP2uivDelegate(uint type, uint[] value);
		private delegate void glVertexP3uiDelegate(uint type, uint value);
		private delegate void glVertexP3uivDelegate(uint type, uint[] value);
		private delegate void glVertexP4uiDelegate(uint type, uint value);
		private delegate void glVertexP4uivDelegate(uint type, uint[] value);
		private delegate void glTexCoordP1uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP1uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP2uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP2uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP3uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP3uivDelegate(uint type, uint[] coords);
		private delegate void glTexCoordP4uiDelegate(uint type, uint coords);
		private delegate void glTexCoordP4uivDelegate(uint type, uint[] coords);
		private delegate void glMultiTexCoordP1uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP1uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP2uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP2uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP3uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP3uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glMultiTexCoordP4uiDelegate(uint texture, uint type, uint coords);
		private delegate void glMultiTexCoordP4uivDelegate(uint texture, uint type, uint[] coords);
		private delegate void glNormalP3uiDelegate(uint type, uint coords);
		private delegate void glNormalP3uivDelegate(uint type, uint[] coords);
		private delegate void glColorP3uiDelegate(uint type, uint color);
		private delegate void glColorP3uivDelegate(uint type, uint[] color);
		private delegate void glColorP4uiDelegate(uint type, uint color);
		private delegate void glColorP4uivDelegate(uint type, uint[] color);
		private delegate void glSecondaryColorP3uiDelegate(uint type, uint color);
		private delegate void glSecondaryColorP3uivDelegate(uint type, uint[] color);
        private delegate void glMinSampleShadingDelegate(float value);
		private delegate void glBlendEquationiDelegate(uint buf, uint mode);
		private delegate void glBlendEquationSeparateiDelegate(uint buf, uint modeRGB, uint modeAlpha);
		private delegate void glBlendFunciDelegate(uint buf, uint src, uint dst);
		private delegate void glBlendFuncSeparateiDelegate(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		private delegate void glDrawArraysIndirectDelegate(uint mode, nint indirect);
		private delegate void glDrawElementsIndirectDelegate(uint mode, uint type, nint indirect);
		private delegate void glUniform1dDelegate(uint location, double x);
		private delegate void glUniform2dDelegate(uint location, double x, double y);
		private delegate void glUniform3dDelegate(uint location, double x, double y, double z);
		private delegate void glUniform4dDelegate(uint location, double x, double y, double z, double w);
		private delegate void glUniform1dvDelegate(uint location, int count, double[] value);
		private delegate void glUniform2dvDelegate(uint location, int count, double[] value);
		private delegate void glUniform3dvDelegate(uint location, int count, double[] value);
		private delegate void glUniform4dvDelegate(uint location, int count, double[] value);
		private delegate void glUniformMatrix2dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x3dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix2x4dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x2dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix3x4dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x2dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glUniformMatrix4x3dvDelegate(uint location, int count, bool transpose, double[] value);
		private delegate void glGetUniformdvDelegate(uint program, uint location, double[] @params);
		private delegate int glGetSubroutineUniformLocationDelegate(uint program, uint shadertype, char[] name);
		private delegate uint glGetSubroutineIndexDelegate(uint program, uint shadertype, char[] name);
		private delegate void glGetActiveSubroutineUniformivDelegate(uint program, uint shadertype, uint index, uint pname, int[] values);
		private delegate void glGetActiveSubroutineUniformNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glGetActiveSubroutineNameDelegate(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name);
		private delegate void glUniformSubroutinesuivDelegate(uint shadertype, int count, uint[] indices);
		private delegate void glGetUniformSubroutineuivDelegate(uint shadertype, uint location, uint[] @params);
		private delegate void glGetProgramStageivDelegate(uint program, uint shadertype, uint pname, int[] values);
		private delegate void glPatchParameteriDelegate(uint pname, int value);
		private delegate void glPatchParameterfvDelegate(uint pname, float[] values);
		private delegate void glBindTransformFeedbackDelegate(uint target, uint id);
		private delegate void glDeleteTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glGenTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate bool glIsTransformFeedbackDelegate(uint id);
		private delegate void glPauseTransformFeedbackDelegate();
		private delegate void glResumeTransformFeedbackDelegate();
		private delegate void glDrawTransformFeedbackDelegate(uint mode, uint id);
		private delegate void glDrawTransformFeedbackStreamDelegate(uint mode, uint id, uint stream);
		private delegate void glBeginQueryIndexedDelegate(uint target, uint index, uint id);
		private delegate void glEndQueryIndexedDelegate(uint target, uint index);
		private delegate void glGetQueryIndexedivDelegate(uint target, uint index, uint pname, int[] @params);
        private delegate void glReleaseShaderCompilerDelegate();
		private delegate void glShaderBinaryDelegate(int count, uint[] shaders, uint binaryformat, nint binary, int length);
		private delegate void glGetShaderPrecisionFormatDelegate(uint shadertype, uint precisiontype, int[] range, int[] precision);
		private delegate void glDepthRangefDelegate(float n, float f);
		private delegate void glClearDepthfDelegate(float d);
		private delegate void glGetProgramBinaryDelegate(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary);
		private delegate void glProgramBinaryDelegate(uint program, uint binaryFormat, nint binary, int length);
		private delegate void glProgramParameteriDelegate(uint program, uint pname, int value);
		private delegate void glUseProgramStagesDelegate(uint pipeline, uint stages, uint program);
		private delegate void glActiveShaderProgramDelegate(uint pipeline, uint program);
		private delegate uint glCreateShaderProgramvDelegate(uint type, int count, char[] strings);
		private delegate void glBindProgramPipelineDelegate(uint pipeline);
		private delegate void glDeleteProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glGenProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate bool glIsProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineivDelegate(uint pipeline, uint pname, int[] @params);
		private delegate void glProgramUniform1iDelegate(uint program, uint location, int v0);
		private delegate void glProgramUniform1ivDelegate(uint program, uint location, int count, int[] value);
		private delegate void glProgramUniform1fDelegate(uint program, uint location, float v0);
		private delegate void glProgramUniform1fvDelegate(uint program, uint location, int count, float[] value);
		private delegate void glProgramUniform1dDelegate(uint program, uint location, double v0);
		private delegate void glProgramUniform1dvDelegate(uint program, uint location, int count, double[] value);
		private delegate void glProgramUniform1uiDelegate(uint program, uint location, uint v0);
		private delegate void glProgramUniform1uivDelegate(uint program, uint location, int count, uint[] value);
		private delegate void glProgramUniform2iDelegate(uint program, uint location, int v0, int v1);
		private delegate void glProgramUniform2ivDelegate(uint program, uint location, int count, int[] value);
		private delegate void glProgramUniform2fDelegate(uint program, uint location, float v0, float v1);
		private delegate void glProgramUniform2fvDelegate(uint program, uint location, int count, float[] value);
		private delegate void glProgramUniform2dDelegate(uint program, uint location, double v0, double v1);
		private delegate void glProgramUniform2dvDelegate(uint program, uint location, int count, double[] value);
		private delegate void glProgramUniform2uiDelegate(uint program, uint location, uint v0, uint v1);
		private delegate void glProgramUniform2uivDelegate(uint program, uint location, int count, uint[] value);
		private delegate void glProgramUniform3iDelegate(uint program, uint location, int v0, int v1, int v2);
		private delegate void glProgramUniform3ivDelegate(uint program, uint location, int count, int[] value);
		private delegate void glProgramUniform3fDelegate(uint program, uint location, float v0, float v1, float v2);
		private delegate void glProgramUniform3fvDelegate(uint program, uint location, int count, float[] value);
		private delegate void glProgramUniform3dDelegate(uint program, uint location, double v0, double v1, double v2);
		private delegate void glProgramUniform3dvDelegate(uint program, uint location, int count, double[] value);
		private delegate void glProgramUniform3uiDelegate(uint program, uint location, uint v0, uint v1, uint v2);
		private delegate void glProgramUniform3uivDelegate(uint program, uint location, int count, uint[] value);
		private delegate void glProgramUniform4iDelegate(uint program, uint location, int v0, int v1, int v2, int v3);
		private delegate void glProgramUniform4ivDelegate(uint program, uint location, int count, int[] value);
		private delegate void glProgramUniform4fDelegate(uint program, uint location, float v0, float v1, float v2, float v3);
		private delegate void glProgramUniform4fvDelegate(uint program, uint location, int count, float[] value);
		private delegate void glProgramUniform4dDelegate(uint program, uint location, double v0, double v1, double v2, double v3);
		private delegate void glProgramUniform4dvDelegate(uint program, uint location, int count, double[] value);
		private delegate void glProgramUniform4uiDelegate(uint program, uint location, uint v0, uint v1, uint v2, uint v3);
		private delegate void glProgramUniform4uivDelegate(uint program, uint location, int count, uint[] value);
		private delegate void glProgramUniformMatrix2fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x3fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x2fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x4fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x2fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix3x4fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix4x3fvDelegate(uint program, uint location, int count, bool transpose, float[] value);
		private delegate void glProgramUniformMatrix2x3dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x2dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix2x4dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x2dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix3x4dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glProgramUniformMatrix4x3dvDelegate(uint program, uint location, int count, bool transpose, double[] value);
		private delegate void glValidateProgramPipelineDelegate(uint pipeline);
		private delegate void glGetProgramPipelineInfoLogDelegate(uint pipeline, int bufSize, int[] length, char[] infoLog);
		private delegate void glVertexAttribL1dDelegate(uint index, double x);
		private delegate void glVertexAttribL2dDelegate(uint index, double x, double y);
		private delegate void glVertexAttribL3dDelegate(uint index, double x, double y, double z);
		private delegate void glVertexAttribL4dDelegate(uint index, double x, double y, double z, double w);
		private delegate void glVertexAttribL1dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL2dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL3dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribL4dvDelegate(uint index, double[] v);
		private delegate void glVertexAttribLPointerDelegate(uint index, int size, uint type, int stride, nint pointer);
		private delegate void glGetVertexAttribLdvDelegate(uint index, uint pname, double[] @params);
		private delegate void glViewportArrayvDelegate(uint first, int count, float[] v);
		private delegate void glViewportIndexedfDelegate(uint index, float x, float y, float w, float h);
		private delegate void glViewportIndexedfvDelegate(uint index, float[] v);
		private delegate void glScissorArrayvDelegate(uint first, int count, int[] v);
		private delegate void glScissorIndexedDelegate(uint index, int left, int bottom, int width, int height);
		private delegate void glScissorIndexedvDelegate(uint index, int[] v);
		private delegate void glDepthRangeArrayvDelegate(uint first, int count, double[] v);
		private delegate void glDepthRangeIndexedDelegate(uint index, double n, double f);
		private delegate void glGetFloati_vDelegate(uint target, uint index, float[] data);
		private delegate void glGetDoublei_vDelegate(uint target, uint index, double[] data);
        private delegate void glDrawArraysInstancedBaseInstanceDelegate(uint mode, int first, int count, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseInstanceDelegate(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance);
		private delegate void glDrawElementsInstancedBaseVertexBaseInstanceDelegate(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance);
		private delegate void glGetInternalformativDelegate(uint target, uint internalformat, uint pname, int bufSize, int[] @params);
		private delegate void glGetActiveAtomicCounterBufferivDelegate(uint program, uint bufferIndex, uint pname, int[] @params);
		private delegate void glBindImageTextureDelegate(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
		private delegate void glMemoryBarrierDelegate(uint barriers);
		private delegate void glTexStorage1DDelegate(uint target, int levels, uint internalformat, int width);
		private delegate void glTexStorage2DDelegate(uint target, int levels, uint internalformat, int width, int height);
		private delegate void glTexStorage3DDelegate(uint target, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glDrawTransformFeedbackInstancedDelegate(uint mode, uint id, int instancecount);
		private delegate void glDrawTransformFeedbackStreamInstancedDelegate(uint mode, uint id, uint stream, int instancecount);
        private delegate void glClearBufferDataDelegate(uint target, uint internalformat, uint format, uint type, nint data);
		private delegate void glClearBufferSubDataDelegate(uint target, uint internalformat, nint offset, nint size, uint format, uint type, nint data);
		private delegate void glDispatchComputeDelegate(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		private delegate void glDispatchComputeIndirectDelegate(nint indirect);
		private delegate void glCopyImageSubDataDelegate(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
		private delegate void glFramebufferParameteriDelegate(uint target, uint pname, int param);
		private delegate void glGetFramebufferParameterivDelegate(uint target, uint pname, int[] @params);
		private delegate void glGetInternalformati64vDelegate(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params);
		private delegate void glInvalidateTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
		private delegate void glInvalidateTexImageDelegate(uint texture, int level);
		private delegate void glInvalidateBufferSubDataDelegate(uint buffer, nint offset, nint length);
		private delegate void glInvalidateBufferDataDelegate(uint buffer);
		private delegate void glInvalidateFramebufferDelegate(uint target, int numAttachments, uint[] attachments);
		private delegate void glInvalidateSubFramebufferDelegate(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glMultiDrawArraysIndirectDelegate(uint mode, nint indirect, int drawcount, int stride);
		private delegate void glMultiDrawElementsIndirectDelegate(uint mode, uint type, nint indirect, int drawcount, int stride);
		private delegate void glGetProgramInterfaceivDelegate(uint program, uint programInterface, uint pname, int[] @params);
		private delegate uint glGetProgramResourceIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glGetProgramResourceNameDelegate(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name);
		private delegate void glGetProgramResourceivDelegate(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params);
		private delegate int glGetProgramResourceLocationDelegate(uint program, uint programInterface, char[] name);
		private delegate int glGetProgramResourceLocationIndexDelegate(uint program, uint programInterface, char[] name);
		private delegate void glShaderStorageBlockBindingDelegate(uint program, uint storageBlockIndex, uint storageBlockBinding);
		private delegate void glTexBufferRangeDelegate(uint target, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glTexStorage2DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTexStorage3DMultisampleDelegate(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureViewDelegate(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
		private delegate void glBindVertexBufferDelegate(uint bindingindex, uint buffer, nint offset, int stride);
		private delegate void glVertexAttribFormatDelegate(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexAttribIFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribLFormatDelegate(uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexAttribBindingDelegate(uint attribindex, uint bindingindex);
		private delegate void glVertexBindingDivisorDelegate(uint bindingindex, uint divisor);
		private delegate void glDebugMessageControlDelegate(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);
		private delegate void glDebugMessageInsertDelegate(uint source, uint type, uint id, uint severity, int length, char[] buf);
		private delegate void glDebugMessageCallbackDelegate(nint callback, nint userParam);
		private delegate uint glGetDebugMessageLogDelegate(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog);
		private delegate void glPushDebugGroupDelegate(uint source, uint id, int length, char[] message);
		private delegate void glPopDebugGroupDelegate();
		private delegate void glObjectLabelDelegate(uint identifier, uint name, int length, char[] label);
		private delegate void glGetObjectLabelDelegate(uint identifier, uint name, int bufSize, int[] length, char[] label);
		private delegate void glObjectPtrLabelDelegate(nint ptr, int length, char[] label);
		private delegate void glGetObjectPtrLabelDelegate(nint ptr, int bufSize, int[] length, char[] label);
		private delegate void glGetPointervDelegate(uint pname, nint @params);
        private delegate void glBufferStorageDelegate(uint target, nint size, nint data, uint flags);
		private delegate void glClearTexImageDelegate(uint texture, int level, uint format, uint type, nint data);
		private delegate void glClearTexSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint data);
		private delegate void glBindBuffersBaseDelegate(uint target, uint first, int count, uint[] buffers);
		private delegate void glBindBuffersRangeDelegate(uint target, uint first, int count, uint[] buffers, nint offsets, nint sizes);
		private delegate void glBindTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindSamplersDelegate(uint first, int count, uint[] samplers);
		private delegate void glBindImageTexturesDelegate(uint first, int count, uint[] textures);
		private delegate void glBindVertexBuffersDelegate(uint first, int count, uint[] buffers, nint offsets, int[] strides);
        private delegate void glClipControlDelegate(uint origin, uint depth);
		private delegate void glCreateTransformFeedbacksDelegate(int n, uint[] ids);
		private delegate void glTransformFeedbackBufferBaseDelegate(uint xfb, uint index, uint buffer);
		private delegate void glTransformFeedbackBufferRangeDelegate(uint xfb, uint index, uint buffer, nint offset, nint size);
		private delegate void glGetTransformFeedbackivDelegate(uint xfb, uint pname, int[] param);
		private delegate void glGetTransformFeedbacki_vDelegate(uint xfb, uint pname, uint index, int[] param);
		private delegate void glGetTransformFeedbacki64_vDelegate(uint xfb, uint pname, uint index, Int64[] param);
		private delegate void glCreateBuffersDelegate(int n, uint[] buffers);
		private delegate void glNamedBufferStorageDelegate(uint buffer, nint size, nint data, uint flags);
		private delegate void glNamedBufferDataDelegate(uint buffer, nint size, nint data, uint usage);
		private delegate void glNamedBufferSubDataDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glCopyNamedBufferSubDataDelegate(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size);
		private delegate void glClearNamedBufferDataDelegate(uint buffer, uint internalformat, uint format, uint type, nint data);
		private delegate void glClearNamedBufferSubDataDelegate(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data);
		private delegate void glMapNamedBufferDelegate(uint buffer, uint access);
		private delegate void glMapNamedBufferRangeDelegate(uint buffer, nint offset, nint length, uint access);
		private delegate bool glUnmapNamedBufferDelegate(uint buffer);
		private delegate void glFlushMappedNamedBufferRangeDelegate(uint buffer, nint offset, nint length);
		private delegate void glGetNamedBufferParameterivDelegate(uint buffer, uint pname, int[] @params);
		private delegate void glGetNamedBufferParameteri64vDelegate(uint buffer, uint pname, Int64[] @params);
		private delegate void glGetNamedBufferPointervDelegate(uint buffer, uint pname, nint @params);
		private delegate void glGetNamedBufferSubDataDelegate(uint buffer, nint offset, nint size, nint data);
		private delegate void glCreateFramebuffersDelegate(int n, uint[] framebuffers);
		private delegate void glNamedFramebufferRenderbufferDelegate(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		private delegate void glNamedFramebufferParameteriDelegate(uint framebuffer, uint pname, int param);
		private delegate void glNamedFramebufferTextureDelegate(uint framebuffer, uint attachment, uint texture, int level);
		private delegate void glNamedFramebufferTextureLayerDelegate(uint framebuffer, uint attachment, uint texture, int level, int layer);
		private delegate void glNamedFramebufferDrawBufferDelegate(uint framebuffer, uint buf);
		private delegate void glNamedFramebufferDrawBuffersDelegate(uint framebuffer, int n, uint[] bufs);
		private delegate void glNamedFramebufferReadBufferDelegate(uint framebuffer, uint src);
		private delegate void glInvalidateNamedFramebufferDataDelegate(uint framebuffer, int numAttachments, uint[] attachments);
		private delegate void glInvalidateNamedFramebufferSubDataDelegate(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height);
		private delegate void glClearNamedFramebufferivDelegate(uint framebuffer, uint buffer, int drawbuffer, int[] value);
		private delegate void glClearNamedFramebufferuivDelegate(uint framebuffer, uint buffer, int drawbuffer, uint[] value);
		private delegate void glClearNamedFramebufferfvDelegate(uint framebuffer, uint buffer, int drawbuffer, float[] value);
		private delegate void glClearNamedFramebufferfiDelegate(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
		private delegate void glBlitNamedFramebufferDelegate(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		private delegate uint glCheckNamedFramebufferStatusDelegate(uint framebuffer, uint target);
		private delegate void glGetNamedFramebufferParameterivDelegate(uint framebuffer, uint pname, int[] param);
		private delegate void glGetNamedFramebufferAttachmentParameterivDelegate(uint framebuffer, uint attachment, uint pname, int[] @params);
		private delegate void glCreateRenderbuffersDelegate(int n, uint[] renderbuffers);
		private delegate void glNamedRenderbufferStorageDelegate(uint renderbuffer, uint internalformat, int width, int height);
		private delegate void glNamedRenderbufferStorageMultisampleDelegate(uint renderbuffer, int samples, uint internalformat, int width, int height);
		private delegate void glGetNamedRenderbufferParameterivDelegate(uint renderbuffer, uint pname, int[] @params);
		private delegate void glCreateTexturesDelegate(uint target, int n, uint[] textures);
		private delegate void glTextureBufferDelegate(uint texture, uint internalformat, uint buffer);
		private delegate void glTextureBufferRangeDelegate(uint texture, uint internalformat, uint buffer, nint offset, nint size);
		private delegate void glTextureStorage1DDelegate(uint texture, int levels, uint internalformat, int width);
		private delegate void glTextureStorage2DDelegate(uint texture, int levels, uint internalformat, int width, int height);
		private delegate void glTextureStorage3DDelegate(uint texture, int levels, uint internalformat, int width, int height, int depth);
		private delegate void glTextureStorage2DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		private delegate void glTextureStorage3DMultisampleDelegate(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		private delegate void glTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		private delegate void glTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels);
		private delegate void glCompressedTextureSubImage1DDelegate(uint texture, int level, int xoffset, int width, uint format, int imageSize, nint data);
		private delegate void glCompressedTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data);
		private delegate void glCompressedTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data);
		private delegate void glCopyTextureSubImage1DDelegate(uint texture, int level, int xoffset, int x, int y, int width);
		private delegate void glCopyTextureSubImage2DDelegate(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		private delegate void glCopyTextureSubImage3DDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		private delegate void glTextureParameterfDelegate(uint texture, uint pname, float param);
		private delegate void glTextureParameterfvDelegate(uint texture, uint pname, float[] param);
		private delegate void glTextureParameteriDelegate(uint texture, uint pname, int param);
		private delegate void glTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glTextureParameterivDelegate(uint texture, uint pname, int[] param);
		private delegate void glGenerateTextureMipmapDelegate(uint texture);
		private delegate void glBindTextureUnitDelegate(uint unit, uint texture);
		private delegate void glGetTextureImageDelegate(uint texture, int level, uint format, uint type, int bufSize, nint pixels);
		private delegate void glGetCompressedTextureImageDelegate(uint texture, int level, int bufSize, nint pixels);
		private delegate void glGetTextureLevelParameterfvDelegate(uint texture, int level, uint pname, float[] @params);
		private delegate void glGetTextureLevelParameterivDelegate(uint texture, int level, uint pname, int[] @params);
		private delegate void glGetTextureParameterfvDelegate(uint texture, uint pname, float[] @params);
		private delegate void glGetTextureParameterIivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glGetTextureParameterIuivDelegate(uint texture, uint pname, uint[] @params);
		private delegate void glGetTextureParameterivDelegate(uint texture, uint pname, int[] @params);
		private delegate void glCreateVertexArraysDelegate(int n, uint[] arrays);
		private delegate void glDisableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glEnableVertexArrayAttribDelegate(uint vaobj, uint index);
		private delegate void glVertexArrayElementBufferDelegate(uint vaobj, uint buffer);
		private delegate void glVertexArrayVertexBufferDelegate(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride);
		private delegate void glVertexArrayVertexBuffersDelegate(uint vaobj, uint first, int count, uint[] buffers, nint offsets, int[] strides);
		private delegate void glVertexArrayAttribBindingDelegate(uint vaobj, uint attribindex, uint bindingindex);
		private delegate void glVertexArrayAttribFormatDelegate(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		private delegate void glVertexArrayAttribIFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayAttribLFormatDelegate(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		private delegate void glVertexArrayBindingDivisorDelegate(uint vaobj, uint bindingindex, uint divisor);
		private delegate void glGetVertexArrayivDelegate(uint vaobj, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexedivDelegate(uint vaobj, uint index, uint pname, int[] param);
		private delegate void glGetVertexArrayIndexed64ivDelegate(uint vaobj, uint index, uint pname, Int64[] param);
		private delegate void glCreateSamplersDelegate(int n, uint[] samplers);
		private delegate void glCreateProgramPipelinesDelegate(int n, uint[] pipelines);
		private delegate void glCreateQueriesDelegate(uint target, int n, uint[] ids);
		private delegate void glGetQueryBufferObjecti64vDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectivDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectui64vDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glGetQueryBufferObjectuivDelegate(uint id, uint buffer, uint pname, nint offset);
		private delegate void glMemoryBarrierByRegionDelegate(uint barriers);
		private delegate void glGetTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, nint pixels);
		private delegate void glGetCompressedTextureSubImageDelegate(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, nint pixels);
		private delegate uint glGetGraphicsResetStatusDelegate();
		private delegate void glGetnCompressedTexImageDelegate(uint target, int lod, int bufSize, nint pixels);
		private delegate void glGetnTexImageDelegate(uint target, int level, uint format, uint type, int bufSize, nint pixels);
		private delegate void glGetnUniformdvDelegate(uint program, uint location, int bufSize, double[] @params);
		private delegate void glGetnUniformfvDelegate(uint program, uint location, int bufSize, float[] @params);
		private delegate void glGetnUniformivDelegate(uint program, uint location, int bufSize, int[] @params);
		private delegate void glGetnUniformuivDelegate(uint program, uint location, int bufSize, uint[] @params);
		private delegate void glReadnPixelsDelegate(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data);
		private delegate void glGetnMapdvDelegate(uint target, uint query, int bufSize, double[] v);
		private delegate void glGetnMapfvDelegate(uint target, uint query, int bufSize, float[] v);
		private delegate void glGetnMapivDelegate(uint target, uint query, int bufSize, int[] v);
		private delegate void glGetnPixelMapfvDelegate(uint map, int bufSize, float[] values);
		private delegate void glGetnPixelMapuivDelegate(uint map, int bufSize, uint[] values);
		private delegate void glGetnPixelMapusvDelegate(uint map, int bufSize, ushort[] values);
		private delegate void glGetnPolygonStippleDelegate(int bufSize, byte[] pattern);
		private delegate void glGetnColorTableDelegate(uint target, uint format, uint type, int bufSize, nint table);
		private delegate void glGetnConvolutionFilterDelegate(uint target, uint format, uint type, int bufSize, nint image);
		private delegate void glGetnSeparableFilterDelegate(uint target, uint format, uint type, int rowBufSize, nint row, int columnBufSize, nint column, nint span);
		private delegate void glGetnHistogramDelegate(uint target, bool reset, uint format, uint type, int bufSize, nint values);
		private delegate void glGetnMinmaxDelegate(uint target, bool reset, uint format, uint type, int bufSize, nint values);
		private delegate void glTextureBarrierDelegate();
		
        #endregion

        #region Commands

        [DllImport(XWGL.LIBGL, SetLastError = true)]
        public static extern unsafe sbyte* glGetString(uint name);
        [DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCullFace(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFrontFace(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glHint(uint target, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLineWidth(float width);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPointSize(float size);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPolygonMode(uint face, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScissor(int x, int y, int width, int height);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameterf(uint target, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameterfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameteri(uint target, uint pname, uint param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexParameteriv(uint target, uint pname, uint[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexImage1D(uint target, int level, uint internalformat, int width, int border, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawBuffer(uint buf);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClear(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearColor(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearStencil(int s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearDepth(double depth);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilMask(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthMask(bool flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDisable(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEnable(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFinish();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFlush();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBlendFunc(uint sfactor, uint dfactor);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLogicOp(uint opcode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilFunc(uint func, int @ref, uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glStencilOp(uint fail, uint zfail, uint zpass);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthFunc(uint func);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelStoref(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelStorei(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glReadBuffer(uint src);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glReadPixels(float x, float y, float width, float height, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetBooleanv(uint pname, bool[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetDoublev(uint pname, double[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern uint glGetError();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetFloatv(uint pname, float[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetIntegerv(uint pname, int[] data);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexImage(uint target, int level, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexParameterfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexParameteriv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glIsEnabled(uint cap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDepthRange(double near, double far);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glViewport(int x, int y, int width, int height);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNewList(uint list, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEndList();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCallList(uint list);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCallLists(int n, uint type, nint lists);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDeleteLists(uint list, int range);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern uint glGenLists(int range);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glListBase(uint @base);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBegin(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3b(byte red, byte green, byte blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3d(double red, double green, double blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3f(float red, float green, float blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3i(int red, int green, int blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3s(short red, short green, short blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ub(byte red, byte green, byte blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ubv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3ui(uint red, uint green, uint blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3uiv(uint[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3us(ushort red, ushort green, ushort blue);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor3usv(ushort[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4b(byte red, byte green, byte blue, byte alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4d(double red, double green, double blue, double alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4f(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4i(int red, int green, int blue, int alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4s(short red, short green, short blue, short alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ubv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4uiv(uint[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColor4usv(ushort[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEdgeFlag(bool flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEdgeFlagv(bool[] flag);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEnd();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexd(double c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexdv(double[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexf(float c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexfv(float[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexi(int c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexiv(int[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexs(short c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexsv(short[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3b(byte nx, byte ny, byte nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3bv(byte[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3d(double nx, double ny, double nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3f(float nx, float ny, float nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3i(int nx, int ny, int nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3s(short nx, short ny, short nz);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormal3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2d(double x, double y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2f(float x, float y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2i(int x, int y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2s(short x, short y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3d(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3f(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3i(int x, int y, int z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3s(short x, short y, short z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4d(double x, double y, double z, double w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4f(float x, float y, float z, float w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4i(int x, int y, int z, int w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4s(short x, short y, short z, short w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRasterPos4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectd(double x1, double y1, double x2, double y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectdv(double[] v1, double[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectf(float x1, float y1, float x2, float y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectfv(float[] v1, float[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRecti(int x1, int y1, int x2, int y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectiv(int[] v1, int[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRects(short x1, short y1, short x2, short y2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRectsv(short[] v1, short[] v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1d(double s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1f(float s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1i(int s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1s(short s);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord1sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2d(double s, double t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2f(float s, float t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2i(int s, int t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2s(short s, short t);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3d(double s, double t, double r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3f(float s, float t, float r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3i(int s, int t, int r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3s(short s, short t, short r);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4d(double s, double t, double r, double q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4f(float s, float t, float r, float q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4i(int s, int t, int r, int q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4s(short s, short t, short r, short q);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoord4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2d(double x, double y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2f(float x, float y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2i(int x, int y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2s(short x, short y);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex2sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3d(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3f(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3i(int x, int y, int z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3s(short x, short y, short z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex3sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4d(double x, double y, double z, double w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4dv(double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4f(float x, float y, float z, float w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4fv(float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4i(int x, int y, int z, int w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4iv(int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4s(short x, short y, short z, short w);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertex4sv(short[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClipPlane(uint plane, double[] equation);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColorMaterial(uint face, uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogfv(uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogi(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFogiv(uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightf(uint light, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightfv(uint light, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLighti(uint light, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightiv(uint light, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModelf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModelfv(uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModeli(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLightModeliv(uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLineStipple(int factor, ushort pattern);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialf(uint face, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialfv(uint face, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMateriali(uint face, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMaterialiv(uint face, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPolygonStipple(byte[] mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glShadeModel(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvf(uint target, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnvi(uint target, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexEnviv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGend(uint coord, uint pname, double param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGendv(uint coord, uint pname, double[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGenf(uint coord, uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGenfv(uint coord, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGeni(uint coord, uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexGeniv(uint coord, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFeedbackBuffer(int size, uint type, float[] buffer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glSelectBuffer(int size, uint[] buffer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern int glRenderMode(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glInitNames();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadName(uint name);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPassThrough(float token);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopName();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushName(uint name);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearAccum(float red, float green, float blue, float alpha);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glClearIndex(float c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexMask(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glAccum(uint op, float value);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopAttrib();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushAttrib(uint mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap1d(uint target, double u1, double u2, int stride, int order, double[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap1f(uint target, float u1, float u2, int stride, int order, float[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid1d(int un, double u1, double u2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid1f(int un, float u1, float u2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1d(double u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1dv(double[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1f(float u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord1fv(float[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2d(double u, double v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2dv(double[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2f(float u, float v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalCoord2fv(float[] u);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalMesh1(uint mode, int i1, int i2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalPoint1(int i);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEvalPoint2(int i, int j);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glAlphaFunc(uint func, float @ref);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelZoom(float xfactor, float yfactor);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelTransferf(uint pname, float param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelTransferi(uint pname, int param);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapfv(uint map, int mapsize, float[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapuiv(uint map, int mapsize, uint[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPixelMapusv(uint map, int mapsize, ushort[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyPixels(int x, int y, int width, int height, uint type);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetClipPlane(uint plane, double[] equation);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetLightfv(uint light, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetLightiv(uint light, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapdv(uint target, uint query, double[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapfv(uint target, uint query, float[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMapiv(uint target, uint query, int[] v);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMaterialfv(uint face, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetMaterialiv(uint face, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapfv(uint map, float[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapuiv(uint map, uint[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPixelMapusv(uint map, ushort[] values);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPolygonStipple(byte[] mask);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexEnvfv(uint target, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexEnviv(uint target, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGendv(uint coord, uint pname, double[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGenfv(uint coord, uint pname, float[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetTexGeniv(uint coord, uint pname, int[] @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glIsList(uint list);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadIdentity();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadMatrixf(float[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glLoadMatrixd(double[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMatrixMode(uint mode);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMultMatrixf(float[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glMultMatrixd(double[] m);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopMatrix();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushMatrix();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRotated(double angle, double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glRotatef(float angle, float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScaled(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glScalef(float x, float y, float z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTranslated(double x, double y, double z);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTranslatef(float x, float y, float z);
        [DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawArrays(uint mode, int first, int count);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDrawElements(uint mode, int count, uint type, nint indices);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGetPointerv(uint pname, nint @params);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPolygonOffset(float factor, float units);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glBindTexture(uint target, uint texture);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDeleteTextures(int n, uint[] textures);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glGenTextures(int n, uint[] textures);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glIsTexture(uint texture);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glArrayElement(int i);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glColorPointer(int size, uint type, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glDisableClientState(uint array);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEdgeFlagPointer(int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glEnableClientState(uint array);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexPointer(uint type, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glInterleavedArrays(uint format, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glNormalPointer(uint type, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glTexCoordPointer(int size, uint type, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glVertexPointer(int size, uint type, int stride, nint pointer);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern bool glAreTexturesResident(int n, uint[] textures, bool[] residences);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPrioritizeTextures(int n, uint[] textures, float[] priorities);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexub(byte c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glIndexubv(byte[] c);
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPopClientAttrib();
		[DllImport(XWGL.LIBGL, SetLastError = true)]
		public static extern void glPushClientAttrib(uint mask);

        public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, nint indices)
		{
			XWGL.GetDelegateFor<glDrawRangeElementsDelegate>()(mode, start, end, count, type, indices);
		}
		
		public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, nint pixels)
		{
			XWGL.GetDelegateFor<glTexImage3DDelegate>()(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}
		
		public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			XWGL.GetDelegateFor<glTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glCopyTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

        public static void glActiveTexture(uint texture)
		{
			XWGL.GetDelegateFor<glActiveTextureDelegate>()(texture);
		}
		
		public static void glSampleCoverage(float value, bool invert)
		{
			XWGL.GetDelegateFor<glSampleCoverageDelegate>()(value, invert);
		}
		
		public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexImage3DDelegate>()(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		
		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexImage2DDelegate>()(target, level, internalformat, width, height, border, imageSize, data);
		}
		
		public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexImage1DDelegate>()(target, level, internalformat, width, border, imageSize, data);
		}
		
		public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexSubImage3DDelegate>()(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexSubImage2DDelegate>()(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTexSubImage1DDelegate>()(target, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glGetCompressedTexImage(uint target, int level, nint img)
		{
			XWGL.GetDelegateFor<glGetCompressedTexImageDelegate>()(target, level, img);
		}
		
		public static void glClientActiveTexture(uint texture)
		{
			XWGL.GetDelegateFor<glClientActiveTextureDelegate>()(texture);
		}
		
		public static void glMultiTexCoord1d(uint target, double s)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1dDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1dv(uint target, double[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1f(uint target, float s)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1fDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1fv(uint target, float[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1i(uint target, int s)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1iDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1iv(uint target, int[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord1s(uint target, short s)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1sDelegate>()(target, s);
		}
		
		public static void glMultiTexCoord1sv(uint target, short[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord1svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2d(uint target, double s, double t)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2dDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2dv(uint target, double[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2f(uint target, float s, float t)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2fDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2fv(uint target, float[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2i(uint target, int s, int t)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2iDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2iv(uint target, int[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord2s(uint target, short s, short t)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2sDelegate>()(target, s, t);
		}
		
		public static void glMultiTexCoord2sv(uint target, short[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord2svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3d(uint target, double s, double t, double r)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3dDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3dv(uint target, double[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3f(uint target, float s, float t, float r)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3fDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3fv(uint target, float[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3i(uint target, int s, int t, int r)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3iDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3iv(uint target, int[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord3s(uint target, short s, short t, short r)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3sDelegate>()(target, s, t, r);
		}
		
		public static void glMultiTexCoord3sv(uint target, short[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord3svDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4d(uint target, double s, double t, double r, double q)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4dDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4dv(uint target, double[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4dvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4f(uint target, float s, float t, float r, float q)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4fDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4fv(uint target, float[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4fvDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4i(uint target, int s, int t, int r, int q)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4iDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4iv(uint target, int[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4ivDelegate>()(target, v);
		}
		
		public static void glMultiTexCoord4s(uint target, short s, short t, short r, short q)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4sDelegate>()(target, s, t, r, q);
		}
		
		public static void glMultiTexCoord4sv(uint target, short[] v)
		{
			XWGL.GetDelegateFor<glMultiTexCoord4svDelegate>()(target, v);
		}
		
		public static void glLoadTransposeMatrixf(float[] m)
		{
			XWGL.GetDelegateFor<glLoadTransposeMatrixfDelegate>()(m);
		}
		
		public static void glLoadTransposeMatrixd(double[] m)
		{
			XWGL.GetDelegateFor<glLoadTransposeMatrixdDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixf(float[] m)
		{
			XWGL.GetDelegateFor<glMultTransposeMatrixfDelegate>()(m);
		}
		
		public static void glMultTransposeMatrixd(double[] m)
		{
			XWGL.GetDelegateFor<glMultTransposeMatrixdDelegate>()(m);
		}

        public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			XWGL.GetDelegateFor<glBlendFuncSeparateDelegate>()(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}
		
		public static void glMultiDrawArrays(uint mode, int[] first, int[] count, int drawcount)
		{
			XWGL.GetDelegateFor<glMultiDrawArraysDelegate>()(mode, first, count, drawcount);
		}
		
		public static void glMultiDrawElements(uint mode, int[] count, uint type, nint indices, int drawcount)
		{
			XWGL.GetDelegateFor<glMultiDrawElementsDelegate>()(mode, count, type, indices, drawcount);
		}
		
		public static void glPointParameterf(uint pname, float param)
		{
			XWGL.GetDelegateFor<glPointParameterfDelegate>()(pname, param);
		}
		
		public static void glPointParameterfv(uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glPointParameterfvDelegate>()(pname, @params);
		}
		
		public static void glPointParameteri(uint pname, int param)
		{
			XWGL.GetDelegateFor<glPointParameteriDelegate>()(pname, param);
		}
		
		public static void glPointParameteriv(uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glPointParameterivDelegate>()(pname, @params);
		}
		
		public static void glFogCoordf(float coord)
		{
			XWGL.GetDelegateFor<glFogCoordfDelegate>()(coord);
		}
		
		public static void glFogCoordfv(float[] coord)
		{
			XWGL.GetDelegateFor<glFogCoordfvDelegate>()(coord);
		}
		
		public static void glFogCoordd(double coord)
		{
			XWGL.GetDelegateFor<glFogCoorddDelegate>()(coord);
		}
		
		public static void glFogCoorddv(double[] coord)
		{
			XWGL.GetDelegateFor<glFogCoorddvDelegate>()(coord);
		}
		
		public static void glFogCoordPointer(uint type, int stride, nint pointer)
		{
			XWGL.GetDelegateFor<glFogCoordPointerDelegate>()(type, stride, pointer);
		}
		
		public static void glSecondaryColor3b(byte red, byte green, byte blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3bDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3bv(byte[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3bvDelegate>()(v);
		}
		
		public static void glSecondaryColor3d(double red, double green, double blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3dDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3dv(double[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3dvDelegate>()(v);
		}
		
		public static void glSecondaryColor3f(float red, float green, float blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3fDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3fv(float[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3fvDelegate>()(v);
		}
		
		public static void glSecondaryColor3i(int red, int green, int blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3iDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3iv(int[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ivDelegate>()(v);
		}
		
		public static void glSecondaryColor3s(short red, short green, short blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3sDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3sv(short[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3svDelegate>()(v);
		}
		
		public static void glSecondaryColor3ub(byte red, byte green, byte blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ubDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3ubv(byte[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3ubvDelegate>()(v);
		}
		
		public static void glSecondaryColor3ui(uint red, uint green, uint blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3uiDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3uiv(uint[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3uivDelegate>()(v);
		}
		
		public static void glSecondaryColor3us(ushort red, ushort green, ushort blue)
		{
			XWGL.GetDelegateFor<glSecondaryColor3usDelegate>()(red, green, blue);
		}
		
		public static void glSecondaryColor3usv(ushort[] v)
		{
			XWGL.GetDelegateFor<glSecondaryColor3usvDelegate>()(v);
		}
		
		public static void glSecondaryColorPointer(int size, uint type, int stride, nint pointer)
		{
			XWGL.GetDelegateFor<glSecondaryColorPointerDelegate>()(size, type, stride, pointer);
		}
		
		public static void glWindowPos2d(double x, double y)
		{
			XWGL.GetDelegateFor<glWindowPos2dDelegate>()(x, y);
		}
		
		public static void glWindowPos2dv(double[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2dvDelegate>()(v);
		}
		
		public static void glWindowPos2f(float x, float y)
		{
			XWGL.GetDelegateFor<glWindowPos2fDelegate>()(x, y);
		}
		
		public static void glWindowPos2fv(float[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2fvDelegate>()(v);
		}
		
		public static void glWindowPos2i(int x, int y)
		{
			XWGL.GetDelegateFor<glWindowPos2iDelegate>()(x, y);
		}
		
		public static void glWindowPos2iv(int[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2ivDelegate>()(v);
		}
		
		public static void glWindowPos2s(short x, short y)
		{
			XWGL.GetDelegateFor<glWindowPos2sDelegate>()(x, y);
		}
		
		public static void glWindowPos2sv(short[] v)
		{
			XWGL.GetDelegateFor<glWindowPos2svDelegate>()(v);
		}
		
		public static void glWindowPos3d(double x, double y, double z)
		{
			XWGL.GetDelegateFor<glWindowPos3dDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3dv(double[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3dvDelegate>()(v);
		}
		
		public static void glWindowPos3f(float x, float y, float z)
		{
			XWGL.GetDelegateFor<glWindowPos3fDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3fv(float[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3fvDelegate>()(v);
		}
		
		public static void glWindowPos3i(int x, int y, int z)
		{
			XWGL.GetDelegateFor<glWindowPos3iDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3iv(int[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3ivDelegate>()(v);
		}
		
		public static void glWindowPos3s(short x, short y, short z)
		{
			XWGL.GetDelegateFor<glWindowPos3sDelegate>()(x, y, z);
		}
		
		public static void glWindowPos3sv(short[] v)
		{
			XWGL.GetDelegateFor<glWindowPos3svDelegate>()(v);
		}
		
		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			XWGL.GetDelegateFor<glBlendColorDelegate>()(red, green, blue, alpha);
		}
		
		public static void glBlendEquation(uint mode)
		{
			XWGL.GetDelegateFor<glBlendEquationDelegate>()(mode);
		}

        public static void glGenQueries(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glGenQueriesDelegate>()(n, ids);
		}
		
		public static void glDeleteQueries(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glDeleteQueriesDelegate>()(n, ids);
		}
		
		public static bool glIsQuery(uint id)
		{
			return (bool)XWGL.GetDelegateFor<glIsQueryDelegate>()(id);
		}
		
		public static void glBeginQuery(uint target, uint id)
		{
			XWGL.GetDelegateFor<glBeginQueryDelegate>()(target, id);
		}
		
		public static void glEndQuery(uint target)
		{
			XWGL.GetDelegateFor<glEndQueryDelegate>()(target);
		}
		
		public static void glGetQueryiv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryivDelegate>()(target, pname, @params);
		}
		
		public static void glGetQueryObjectiv(uint id, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryObjectivDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectuiv(uint id, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryObjectuivDelegate>()(id, pname, @params);
		}
		
		public static void glBindBuffer(uint target, uint buffer)
		{
			XWGL.GetDelegateFor<glBindBufferDelegate>()(target, buffer);
		}
		
		public static void glDeleteBuffers(int n, uint[] buffers)
		{
			XWGL.GetDelegateFor<glDeleteBuffersDelegate>()(n, buffers);
		}
		
		public static void glGenBuffers(int n, uint[] buffers)
		{
			XWGL.GetDelegateFor<glGenBuffersDelegate>()(n, buffers);
		}
		
		public static bool glIsBuffer(uint buffer)
		{
			return (bool)XWGL.GetDelegateFor<glIsBufferDelegate>()(buffer);
		}
		
		public static void glBufferData(uint target, int size, float[] data, uint usage)
		{
			XWGL.GetDelegateFor<glBufferDataFloatDelegate>("glBufferData")(target, size, data, usage);
		}

		public static void glBufferData(uint target, int size, uint[] data, uint usage)
		{
			XWGL.GetDelegateFor<glBufferDataUintDelegate>("glBufferData")(target, size, data, usage);
		}

		public static void glBufferData(uint target, int size, int[] data, uint usage)
		{
			XWGL.GetDelegateFor<glBufferDataIntDelegate>("glBufferData")(target, size, data, usage);
		}

		public static void glBufferData(uint target, int size, double[] data, uint usage)
		{
			XWGL.GetDelegateFor<glBufferDataDoubleDelegate>("glBufferData")(target, size, data, usage);
		}
		
		public static void glBufferSubData(uint target, int offset, int size, float[] data)
		{
			XWGL.GetDelegateFor<glBufferSubDataDelegate>()(target, offset, size, data);
		}
		
		public static void glGetBufferSubData(uint target, nint offset, nint size, nint data)
		{
			XWGL.GetDelegateFor<glGetBufferSubDataDelegate>()(target, offset, size, data);
		}
		
		public static void glMapBuffer(uint target, uint access)
		{
			XWGL.GetDelegateFor<glMapBufferDelegate>()(target, access);
		}
		
		public static bool glUnmapBuffer(uint target)
		{
			return (bool)XWGL.GetDelegateFor<glUnmapBufferDelegate>()(target);
		}
		
		public static void glGetBufferParameteriv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetBufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetBufferPointerv(uint target, uint pname, nint @params)
		{
			XWGL.GetDelegateFor<glGetBufferPointervDelegate>()(target, pname, @params);
		}

        public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			XWGL.GetDelegateFor<glBlendEquationSeparateDelegate>()(modeRGB, modeAlpha);
		}
		
		public static void glDrawBuffers(int n, uint[] bufs)
		{
			XWGL.GetDelegateFor<glDrawBuffersDelegate>()(n, bufs);
		}
		
		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			XWGL.GetDelegateFor<glStencilOpSeparateDelegate>()(face, sfail, dpfail, dppass);
		}
		
		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			XWGL.GetDelegateFor<glStencilFuncSeparateDelegate>()(face, func, @ref, mask);
		}
		
		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			XWGL.GetDelegateFor<glStencilMaskSeparateDelegate>()(face, mask);
		}
		
		public static void glAttachShader(uint program, uint shader)
		{
			XWGL.GetDelegateFor<glAttachShaderDelegate>()(program, shader);
		}
		
		public static void glBindAttribLocation(uint program, uint index, string[] name)
		{
			XWGL.GetDelegateFor<glBindAttribLocationDelegate>()(program, index, name);
		}
		
		public static void glCompileShader(uint shader)
		{
			XWGL.GetDelegateFor<glCompileShaderDelegate>()(shader);
		}
		
		public static uint glCreateProgram()
		{
			return (uint)XWGL.GetDelegateFor<glCreateProgramDelegate>()();
		}
		
		public static uint glCreateShader(uint type)
		{
			return (uint)XWGL.GetDelegateFor<glCreateShaderDelegate>()(type);
		}
		
		public static void glDeleteProgram(uint program)
		{
			XWGL.GetDelegateFor<glDeleteProgramDelegate>()(program);
		}
		
		public static void glDeleteShader(uint shader)
		{
			XWGL.GetDelegateFor<glDeleteShaderDelegate>()(shader);
		}
		
		public static void glDetachShader(uint program, uint shader)
		{
			XWGL.GetDelegateFor<glDetachShaderDelegate>()(program, shader);
		}
		
		public static void glDisableVertexAttribArray(uint index)
		{
			XWGL.GetDelegateFor<glDisableVertexAttribArrayDelegate>()(index);
		}
		
		public static void glEnableVertexAttribArray(uint index)
		{
			XWGL.GetDelegateFor<glEnableVertexAttribArrayDelegate>()(index);
		}
		
		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name)
		{
			XWGL.GetDelegateFor<glGetActiveAttribDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glGetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, string[] name)
		{
			XWGL.GetDelegateFor<glGetActiveUniformDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glGetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders)
		{
			XWGL.GetDelegateFor<glGetAttachedShadersDelegate>()(program, maxCount, count, shaders);
		}
		
		public static uint glGetAttribLocation(uint program, string name)
		{
			return (uint)XWGL.GetDelegateFor<glGetAttribLocationDelegate>()(program, name);
		}
		
		public static void glGetProgramiv(uint program, uint pname, ref int @params)
		{
			XWGL.GetDelegateFor<glGetProgramivDelegate>()(program, pname, ref @params);
		}
		
		public static void glGetProgramInfoLog(uint program, int bufSize, ref int length, byte[] infoLog)
		{
			XWGL.GetDelegateFor<glGetProgramInfoLogDelegate>()(program, bufSize, ref length, infoLog);
		}
		
		public static void glGetShaderiv(uint shader, uint pname, ref int @params)
		{
			XWGL.GetDelegateFor<glGetShaderivDelegate>()(shader, pname, ref @params);
		}
		
		public static void glGetShaderInfoLog(uint shader, int bufSize, ref int length, byte[] infoLog)
		{
			XWGL.GetDelegateFor<glGetShaderInfoLogDelegate>()(shader, bufSize, ref length, infoLog);
		}
		
		public static void glGetShaderSource(uint shader, int bufSize, int[] length, char[] source)
		{
			XWGL.GetDelegateFor<glGetShaderSourceDelegate>()(shader, bufSize, length, source);
		}
		
		public static uint glGetUniformLocation(uint program, string name)
		{
			return (uint)XWGL.GetDelegateFor<glGetUniformLocationDelegate>()(program, name);
		}
		
		public static void glGetUniformfv(uint program, uint location, float[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformfvDelegate>()(program, location, @params);
		}
		
		public static void glGetUniformiv(uint program, uint location, int[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformivDelegate>()(program, location, @params);
		}
		
		public static void glGetVertexAttribdv(uint index, uint pname, double[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribdvDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribfv(uint index, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribfvDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribiv(uint index, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribivDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribPointerv(uint index, uint pname, nint pointer)
		{
			XWGL.GetDelegateFor<glGetVertexAttribPointervDelegate>()(index, pname, pointer);
		}
		
		public static bool glIsProgram(uint program)
		{
			return (bool)XWGL.GetDelegateFor<glIsProgramDelegate>()(program);
		}
		
		public static bool glIsShader(uint shader)
		{
			return (bool)XWGL.GetDelegateFor<glIsShaderDelegate>()(shader);
		}
		
		public static void glLinkProgram(uint program)
		{
			XWGL.GetDelegateFor<glLinkProgramDelegate>()(program);
		}
		
		public static void glShaderSource(uint shader, int count, string[] @string, int[] length)
		{
			XWGL.GetDelegateFor<glShaderSourceDelegate>()(shader, count, @string, length);
		}
		
		public static void glUseProgram(uint program)
		{
			XWGL.GetDelegateFor<glUseProgramDelegate>()(program);
		}
		
		public static void glUniform1f(uint location, float v0)
		{
			XWGL.GetDelegateFor<glUniform1fDelegate>()(location, v0);
		}
		
		public static void glUniform2f(uint location, float v0, float v1)
		{
			XWGL.GetDelegateFor<glUniform2fDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3f(uint location, float v0, float v1, float v2)
		{
			XWGL.GetDelegateFor<glUniform3fDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4f(uint location, float v0, float v1, float v2, float v3)
		{
			XWGL.GetDelegateFor<glUniform4fDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1i(uint location, int v0)
		{
			XWGL.GetDelegateFor<glUniform1iDelegate>()(location, v0);
		}
		
		public static void glUniform2i(uint location, int v0, int v1)
		{
			XWGL.GetDelegateFor<glUniform2iDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3i(uint location, int v0, int v1, int v2)
		{
			XWGL.GetDelegateFor<glUniform3iDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4i(uint location, int v0, int v1, int v2, int v3)
		{
			XWGL.GetDelegateFor<glUniform4iDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform1fvDelegate>()(location, count, value);
		}
		
		public static void glUniform2fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform2fvDelegate>()(location, count, value);
		}
		
		public static void glUniform3fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform3fvDelegate>()(location, count, value);
		}
		
		public static void glUniform4fv(uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glUniform4fvDelegate>()(location, count, value);
		}
		
		public static void glUniform1iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform1ivDelegate>()(location, count, value);
		}
		
		public static void glUniform2iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform2ivDelegate>()(location, count, value);
		}
		
		public static void glUniform3iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform3ivDelegate>()(location, count, value);
		}
		
		public static void glUniform4iv(uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glUniform4ivDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glValidateProgram(uint program)
		{
			XWGL.GetDelegateFor<glValidateProgramDelegate>()(program);
		}
		
		public static void glVertexAttrib1d(uint index, double x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1dDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1f(uint index, float x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1fDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib1s(uint index, short x)
		{
			XWGL.GetDelegateFor<glVertexAttrib1sDelegate>()(index, x);
		}
		
		public static void glVertexAttrib1sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib1svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2d(uint index, double x, double y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2dDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2fDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib2s(uint index, short x, short y)
		{
			XWGL.GetDelegateFor<glVertexAttrib2sDelegate>()(index, x, y);
		}
		
		public static void glVertexAttrib2sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib2svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3d(uint index, double x, double y, double z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3dDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3fDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib3s(uint index, short x, short y, short z)
		{
			XWGL.GetDelegateFor<glVertexAttrib3sDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttrib3sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib3svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nbv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NbvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Niv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nsv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NsvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NubDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4Nubv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NubvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nuiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NuivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4Nusv(uint index, ushort[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4NusvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4bv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4bvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4dDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4dvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4fDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4fv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4fvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4ivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			XWGL.GetDelegateFor<glVertexAttrib4sDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttrib4sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4svDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4ubv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4ubvDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4uivDelegate>()(index, v);
		}
		
		public static void glVertexAttrib4usv(uint index, ushort[] v)
		{
			XWGL.GetDelegateFor<glVertexAttrib4usvDelegate>()(index, v);
		}
		
		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, nint pointer)
		{
			XWGL.GetDelegateFor<glVertexAttribPointerDelegate>()(index, size, type, normalized, stride, pointer);
		}

        public static void glUniformMatrix2x3fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x3fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x2fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x4fvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3fv(uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x3fvDelegate>()(location, count, transpose, value);
		}

        public static void glColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			XWGL.GetDelegateFor<glColorMaskiDelegate>()(index, r, g, b, a);
		}
		
		public static void glGetBooleani_v(uint target, uint index, bool[] data)
		{
			XWGL.GetDelegateFor<glGetBooleani_vDelegate>()(target, index, data);
		}
		
		public static void glGetIntegeri_v(uint target, uint index, int[] data)
		{
			XWGL.GetDelegateFor<glGetIntegeri_vDelegate>()(target, index, data);
		}
		
		public static void glEnablei(uint target, uint index)
		{
			XWGL.GetDelegateFor<glEnableiDelegate>()(target, index);
		}
		
		public static void glDisablei(uint target, uint index)
		{
			XWGL.GetDelegateFor<glDisableiDelegate>()(target, index);
		}
		
		public static bool glIsEnabledi(uint target, uint index)
		{
			return (bool)XWGL.GetDelegateFor<glIsEnablediDelegate>()(target, index);
		}
		
		public static void glBeginTransformFeedback(uint primitiveMode)
		{
			XWGL.GetDelegateFor<glBeginTransformFeedbackDelegate>()(primitiveMode);
		}
		
		public static void glEndTransformFeedback()
		{
			XWGL.GetDelegateFor<glEndTransformFeedbackDelegate>()();
		}
		
		public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size)
		{
			XWGL.GetDelegateFor<glBindBufferRangeDelegate>()(target, index, buffer, offset, size);
		}
		
		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			XWGL.GetDelegateFor<glBindBufferBaseDelegate>()(target, index, buffer);
		}
		
		public static void glTransformFeedbackVaryings(uint program, int count, char[] varyings, uint bufferMode)
		{
			XWGL.GetDelegateFor<glTransformFeedbackVaryingsDelegate>()(program, count, varyings, bufferMode);
		}
		
		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, char[] name)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbackVaryingDelegate>()(program, index, bufSize, length, size, type, name);
		}
		
		public static void glClampColor(uint target, uint clamp)
		{
			XWGL.GetDelegateFor<glClampColorDelegate>()(target, clamp);
		}
		
		public static void glBeginConditionalRender(uint id, uint mode)
		{
			XWGL.GetDelegateFor<glBeginConditionalRenderDelegate>()(id, mode);
		}
		
		public static void glEndConditionalRender()
		{
			XWGL.GetDelegateFor<glEndConditionalRenderDelegate>()();
		}
		
		public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, nint pointer)
		{
			XWGL.GetDelegateFor<glVertexAttribIPointerDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribIiv(uint index, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribIivDelegate>()(index, pname, @params);
		}
		
		public static void glGetVertexAttribIuiv(uint index, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribIuivDelegate>()(index, pname, @params);
		}
		
		public static void glVertexAttribI1i(uint index, int x)
		{
			XWGL.GetDelegateFor<glVertexAttribI1iDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2i(uint index, int x, int y)
		{
			XWGL.GetDelegateFor<glVertexAttribI2iDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3i(uint index, int x, int y, int z)
		{
			XWGL.GetDelegateFor<glVertexAttribI3iDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			XWGL.GetDelegateFor<glVertexAttribI4iDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1ui(uint index, uint x)
		{
			XWGL.GetDelegateFor<glVertexAttribI1uiDelegate>()(index, x);
		}
		
		public static void glVertexAttribI2ui(uint index, uint x, uint y)
		{
			XWGL.GetDelegateFor<glVertexAttribI2uiDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			XWGL.GetDelegateFor<glVertexAttribI3uiDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			XWGL.GetDelegateFor<glVertexAttribI4uiDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribI1iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI1ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI2ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI3ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4iv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4ivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI1uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI1uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI2uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI2uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI3uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI3uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4uiv(uint index, uint[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4uivDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4bv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4bvDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4sv(uint index, short[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4svDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4ubv(uint index, byte[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4ubvDelegate>()(index, v);
		}
		
		public static void glVertexAttribI4usv(uint index, ushort[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribI4usvDelegate>()(index, v);
		}
		
		public static void glGetUniformuiv(uint program, uint location, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformuivDelegate>()(program, location, @params);
		}
		
		public static void glBindFragDataLocation(uint program, uint color, char[] name)
		{
			XWGL.GetDelegateFor<glBindFragDataLocationDelegate>()(program, color, name);
		}
		
		public static int glGetFragDataLocation(uint program, char[] name)
		{
			return (int)XWGL.GetDelegateFor<glGetFragDataLocationDelegate>()(program, name);
		}
		
		public static void glUniform1ui(uint location, uint v0)
		{
			XWGL.GetDelegateFor<glUniform1uiDelegate>()(location, v0);
		}
		
		public static void glUniform2ui(uint location, uint v0, uint v1)
		{
			XWGL.GetDelegateFor<glUniform2uiDelegate>()(location, v0, v1);
		}
		
		public static void glUniform3ui(uint location, uint v0, uint v1, uint v2)
		{
			XWGL.GetDelegateFor<glUniform3uiDelegate>()(location, v0, v1, v2);
		}
		
		public static void glUniform4ui(uint location, uint v0, uint v1, uint v2, uint v3)
		{
			XWGL.GetDelegateFor<glUniform4uiDelegate>()(location, v0, v1, v2, v3);
		}
		
		public static void glUniform1uiv(uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glUniform1uivDelegate>()(location, count, value);
		}
		
		public static void glUniform2uiv(uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glUniform2uivDelegate>()(location, count, value);
		}
		
		public static void glUniform3uiv(uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glUniform3uivDelegate>()(location, count, value);
		}
		
		public static void glUniform4uiv(uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glUniform4uivDelegate>()(location, count, value);
		}
		
		public static void glTexParameterIiv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glTexParameterIivDelegate>()(target, pname, @params);
		}
		
		public static void glTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glTexParameterIuivDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIiv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTexParameterIivDelegate>()(target, pname, @params);
		}
		
		public static void glGetTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetTexParameterIuivDelegate>()(target, pname, @params);
		}
		
		public static void glClearBufferiv(uint buffer, int drawbuffer, int[] value)
		{
			XWGL.GetDelegateFor<glClearBufferivDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferuiv(uint buffer, int drawbuffer, uint[] value)
		{
			XWGL.GetDelegateFor<glClearBufferuivDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferfv(uint buffer, int drawbuffer, float[] value)
		{
			XWGL.GetDelegateFor<glClearBufferfvDelegate>()(buffer, drawbuffer, value);
		}
		
		public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			XWGL.GetDelegateFor<glClearBufferfiDelegate>()(buffer, drawbuffer, depth, stencil);
		}
		
		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return (bool)XWGL.GetDelegateFor<glIsRenderbufferDelegate>()(renderbuffer);
		}
		
		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			XWGL.GetDelegateFor<glBindRenderbufferDelegate>()(target, renderbuffer);
		}
		
		public static void glDeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			XWGL.GetDelegateFor<glDeleteRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glGenRenderbuffers(int n, uint[] renderbuffers)
		{
			XWGL.GetDelegateFor<glGenRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glRenderbufferStorageDelegate>()(target, internalformat, width, height);
		}
		
		public static void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetRenderbufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static bool glIsFramebuffer(uint framebuffer)
		{
			return (bool)XWGL.GetDelegateFor<glIsFramebufferDelegate>()(framebuffer);
		}
		
		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			XWGL.GetDelegateFor<glBindFramebufferDelegate>()(target, framebuffer);
		}
		
		public static void glDeleteFramebuffers(int n, uint[] framebuffers)
		{
			XWGL.GetDelegateFor<glDeleteFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glGenFramebuffers(int n, uint[] framebuffers)
		{
			XWGL.GetDelegateFor<glGenFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static uint glCheckFramebufferStatus(uint target)
		{
			return (uint)XWGL.GetDelegateFor<glCheckFramebufferStatusDelegate>()(target);
		}
		
		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			XWGL.GetDelegateFor<glFramebufferTexture1DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			XWGL.GetDelegateFor<glFramebufferTexture2DDelegate>()(target, attachment, textarget, texture, level);
		}
		
		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			XWGL.GetDelegateFor<glFramebufferTexture3DDelegate>()(target, attachment, textarget, texture, level, zoffset);
		}
		
		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			XWGL.GetDelegateFor<glFramebufferRenderbufferDelegate>()(target, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetFramebufferAttachmentParameterivDelegate>()(target, attachment, pname, @params);
		}
		
		public static void glGenerateMipmap(uint target)
		{
			XWGL.GetDelegateFor<glGenerateMipmapDelegate>()(target);
		}
		
		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			XWGL.GetDelegateFor<glBlitFramebufferDelegate>()(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glRenderbufferStorageMultisampleDelegate>()(target, samples, internalformat, width, height);
		}
		
		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			XWGL.GetDelegateFor<glFramebufferTextureLayerDelegate>()(target, attachment, texture, level, layer);
		}
		
		public static void glMapBufferRange(uint target, nint offset, nint length, uint access)
		{
			XWGL.GetDelegateFor<glMapBufferRangeDelegate>()(target, offset, length, access);
		}
		
		public static void glFlushMappedBufferRange(uint target, nint offset, nint length)
		{
			XWGL.GetDelegateFor<glFlushMappedBufferRangeDelegate>()(target, offset, length);
		}
		
		public static void glBindVertexArray(uint array)
		{
			XWGL.GetDelegateFor<glBindVertexArrayDelegate>()(array);
		}
		
		public static void glDeleteVertexArrays(int n, uint[] arrays)
		{
			XWGL.GetDelegateFor<glDeleteVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glGenVertexArrays(int n, uint[] arrays)
		{
			XWGL.GetDelegateFor<glGenVertexArraysDelegate>()(n, arrays);
		}
		
		public static bool glIsVertexArray(uint array)
		{
			return (bool)XWGL.GetDelegateFor<glIsVertexArrayDelegate>()(array);
		}

        public static void glDrawElementsBaseVertex(uint mode, int count, uint type, nint indices, int basevertex)
		{
			XWGL.GetDelegateFor<glDrawElementsBaseVertexDelegate>()(mode, count, type, indices, basevertex);
		}
		
		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, nint indices, int basevertex)
		{
			XWGL.GetDelegateFor<glDrawRangeElementsBaseVertexDelegate>()(mode, start, end, count, type, indices, basevertex);
		}
		
		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, nint indices, int instancecount, int basevertex)
		{
			XWGL.GetDelegateFor<glDrawElementsInstancedBaseVertexDelegate>()(mode, count, type, indices, instancecount, basevertex);
		}
		
		public static void glMultiDrawElementsBaseVertex(uint mode, int[] count, uint type, nint indices, int drawcount, int[] basevertex)
		{
			XWGL.GetDelegateFor<glMultiDrawElementsBaseVertexDelegate>()(mode, count, type, indices, drawcount, basevertex);
		}
		
		public static void glProvokingVertex(uint mode)
		{
			XWGL.GetDelegateFor<glProvokingVertexDelegate>()(mode);
		}
		
		public static nint glFenceSync(uint condition, uint flags)
		{
			return (nint)XWGL.GetDelegateFor<glFenceSyncDelegate>()(condition, flags);
		}
		
		public static bool glIsSync(nint sync)
		{
			return (bool)XWGL.GetDelegateFor<glIsSyncDelegate>()(sync);
		}
		
		public static void glDeleteSync(nint sync)
		{
			XWGL.GetDelegateFor<glDeleteSyncDelegate>()(sync);
		}
		
		public static uint glClientWaitSync(nint sync, uint flags, UInt64 timeout)
		{
			return (uint)XWGL.GetDelegateFor<glClientWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glWaitSync(nint sync, uint flags, UInt64 timeout)
		{
			XWGL.GetDelegateFor<glWaitSyncDelegate>()(sync, flags, timeout);
		}
		
		public static void glGetInteger64v(uint pname, Int64[] data)
		{
			XWGL.GetDelegateFor<glGetInteger64vDelegate>()(pname, data);
		}
		
		public static void glGetSynciv(nint sync, uint pname, int bufSize, int[] length, int[] values)
		{
			XWGL.GetDelegateFor<glGetSyncivDelegate>()(sync, pname, bufSize, length, values);
		}
		
		public static void glGetInteger64i_v(uint target, uint index, Int64[] data)
		{
			XWGL.GetDelegateFor<glGetInteger64i_vDelegate>()(target, index, data);
		}
		
		public static void glGetBufferParameteri64v(uint target, uint pname, Int64[] @params)
		{
			XWGL.GetDelegateFor<glGetBufferParameteri64vDelegate>()(target, pname, @params);
		}
		
		public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			XWGL.GetDelegateFor<glFramebufferTextureDelegate>()(target, attachment, texture, level);
		}
		
		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTexImage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTexImage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glGetMultisamplefv(uint pname, uint index, float[] val)
		{
			XWGL.GetDelegateFor<glGetMultisamplefvDelegate>()(pname, index, val);
		}
		
		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			XWGL.GetDelegateFor<glSampleMaskiDelegate>()(maskNumber, mask);
		}

        public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawArraysInstancedDelegate>()(mode, first, count, instancecount);
		}
		
		public static void glDrawElementsInstanced(uint mode, int count, uint type, nint indices, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawElementsInstancedDelegate>()(mode, count, type, indices, instancecount);
		}
		
		public static void glTexBuffer(uint target, uint internalformat, uint buffer)
		{
			XWGL.GetDelegateFor<glTexBufferDelegate>()(target, internalformat, buffer);
		}
		
		public static void glPrimitiveRestartIndex(uint index)
		{
			XWGL.GetDelegateFor<glPrimitiveRestartIndexDelegate>()(index);
		}
		
		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size)
		{
			XWGL.GetDelegateFor<glCopyBufferSubDataDelegate>()(readTarget, writeTarget, readOffset, writeOffset, size);
		}
		
		public static void glGetUniformIndices(uint program, int uniformCount, char[] uniformNames, uint[] uniformIndices)
		{
			XWGL.GetDelegateFor<glGetUniformIndicesDelegate>()(program, uniformCount, uniformNames, uniformIndices);
		}
		
		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetActiveUniformsivDelegate>()(program, uniformCount, uniformIndices, pname, @params);
		}
		
		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, char[] uniformName)
		{
			XWGL.GetDelegateFor<glGetActiveUniformNameDelegate>()(program, uniformIndex, bufSize, length, uniformName);
		}
		
		public static uint glGetUniformBlockIndex(uint program, char[] uniformBlockName)
		{
			return (uint)XWGL.GetDelegateFor<glGetUniformBlockIndexDelegate>()(program, uniformBlockName);
		}
		
		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetActiveUniformBlockivDelegate>()(program, uniformBlockIndex, pname, @params);
		}
		
		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, char[] uniformBlockName)
		{
			XWGL.GetDelegateFor<glGetActiveUniformBlockNameDelegate>()(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}
		
		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			XWGL.GetDelegateFor<glUniformBlockBindingDelegate>()(program, uniformBlockIndex, uniformBlockBinding);
		}
		
		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char[] name)
		{
			XWGL.GetDelegateFor<glBindFragDataLocationIndexedDelegate>()(program, colorNumber, index, name);
		}
		
		public static int glGetFragDataIndex(uint program, char[] name)
		{
			return (int)XWGL.GetDelegateFor<glGetFragDataIndexDelegate>()(program, name);
		}
		
		public static void glGenSamplers(int count, uint[] samplers)
		{
			XWGL.GetDelegateFor<glGenSamplersDelegate>()(count, samplers);
		}
		
		public static void glDeleteSamplers(int count, uint[] samplers)
		{
			XWGL.GetDelegateFor<glDeleteSamplersDelegate>()(count, samplers);
		}
		
		public static bool glIsSampler(uint sampler)
		{
			return (bool)XWGL.GetDelegateFor<glIsSamplerDelegate>()(sampler);
		}
		
		public static void glBindSampler(uint unit, uint sampler)
		{
			XWGL.GetDelegateFor<glBindSamplerDelegate>()(unit, sampler);
		}
		
		public static void glSamplerParameteri(uint sampler, uint pname, int param)
		{
			XWGL.GetDelegateFor<glSamplerParameteriDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameteriv(uint sampler, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glSamplerParameterivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterf(uint sampler, uint pname, float param)
		{
			XWGL.GetDelegateFor<glSamplerParameterfDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterfv(uint sampler, uint pname, float[] param)
		{
			XWGL.GetDelegateFor<glSamplerParameterfvDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIiv(uint sampler, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glSamplerParameterIivDelegate>()(sampler, pname, param);
		}
		
		public static void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param)
		{
			XWGL.GetDelegateFor<glSamplerParameterIuivDelegate>()(sampler, pname, param);
		}
		
		public static void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetSamplerParameterivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetSamplerParameterIivDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetSamplerParameterfvDelegate>()(sampler, pname, @params);
		}
		
		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetSamplerParameterIuivDelegate>()(sampler, pname, @params);
		}
		
		public static void glQueryCounter(uint id, uint target)
		{
			XWGL.GetDelegateFor<glQueryCounterDelegate>()(id, target);
		}
		
		public static void glGetQueryObjecti64v(uint id, uint pname, Int64[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryObjecti64vDelegate>()(id, pname, @params);
		}
		
		public static void glGetQueryObjectui64v(uint id, uint pname, UInt64[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryObjectui64vDelegate>()(id, pname, @params);
		}
		
		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			XWGL.GetDelegateFor<glVertexAttribDivisorDelegate>()(index, divisor);
		}
		
		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			XWGL.GetDelegateFor<glVertexAttribP1uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexAttribP1uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			XWGL.GetDelegateFor<glVertexAttribP2uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexAttribP2uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			XWGL.GetDelegateFor<glVertexAttribP3uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexAttribP3uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			XWGL.GetDelegateFor<glVertexAttribP4uiDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexAttribP4uivDelegate>()(index, type, normalized, value);
		}
		
		public static void glVertexP2ui(uint type, uint value)
		{
			XWGL.GetDelegateFor<glVertexP2uiDelegate>()(type, value);
		}
		
		public static void glVertexP2uiv(uint type, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexP2uivDelegate>()(type, value);
		}
		
		public static void glVertexP3ui(uint type, uint value)
		{
			XWGL.GetDelegateFor<glVertexP3uiDelegate>()(type, value);
		}
		
		public static void glVertexP3uiv(uint type, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexP3uivDelegate>()(type, value);
		}
		
		public static void glVertexP4ui(uint type, uint value)
		{
			XWGL.GetDelegateFor<glVertexP4uiDelegate>()(type, value);
		}
		
		public static void glVertexP4uiv(uint type, uint[] value)
		{
			XWGL.GetDelegateFor<glVertexP4uivDelegate>()(type, value);
		}
		
		public static void glTexCoordP1ui(uint type, uint coords)
		{
			XWGL.GetDelegateFor<glTexCoordP1uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP1uiv(uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glTexCoordP1uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2ui(uint type, uint coords)
		{
			XWGL.GetDelegateFor<glTexCoordP2uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP2uiv(uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glTexCoordP2uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3ui(uint type, uint coords)
		{
			XWGL.GetDelegateFor<glTexCoordP3uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP3uiv(uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glTexCoordP3uivDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4ui(uint type, uint coords)
		{
			XWGL.GetDelegateFor<glTexCoordP4uiDelegate>()(type, coords);
		}
		
		public static void glTexCoordP4uiv(uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glTexCoordP4uivDelegate>()(type, coords);
		}
		
		public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP1uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP1uiv(uint texture, uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP1uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP2uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP2uiv(uint texture, uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP2uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP3uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP3uiv(uint texture, uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP3uivDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP4uiDelegate>()(texture, type, coords);
		}
		
		public static void glMultiTexCoordP4uiv(uint texture, uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glMultiTexCoordP4uivDelegate>()(texture, type, coords);
		}
		
		public static void glNormalP3ui(uint type, uint coords)
		{
			XWGL.GetDelegateFor<glNormalP3uiDelegate>()(type, coords);
		}
		
		public static void glNormalP3uiv(uint type, uint[] coords)
		{
			XWGL.GetDelegateFor<glNormalP3uivDelegate>()(type, coords);
		}
		
		public static void glColorP3ui(uint type, uint color)
		{
			XWGL.GetDelegateFor<glColorP3uiDelegate>()(type, color);
		}
		
		public static void glColorP3uiv(uint type, uint[] color)
		{
			XWGL.GetDelegateFor<glColorP3uivDelegate>()(type, color);
		}
		
		public static void glColorP4ui(uint type, uint color)
		{
			XWGL.GetDelegateFor<glColorP4uiDelegate>()(type, color);
		}
		
		public static void glColorP4uiv(uint type, uint[] color)
		{
			XWGL.GetDelegateFor<glColorP4uivDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3ui(uint type, uint color)
		{
			XWGL.GetDelegateFor<glSecondaryColorP3uiDelegate>()(type, color);
		}
		
		public static void glSecondaryColorP3uiv(uint type, uint[] color)
		{
			XWGL.GetDelegateFor<glSecondaryColorP3uivDelegate>()(type, color);
		}

        public static void glMinSampleShading(float value)
		{
			XWGL.GetDelegateFor<glMinSampleShadingDelegate>()(value);
		}
		
		public static void glBlendEquationi(uint buf, uint mode)
		{
			XWGL.GetDelegateFor<glBlendEquationiDelegate>()(buf, mode);
		}
		
		public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha)
		{
			XWGL.GetDelegateFor<glBlendEquationSeparateiDelegate>()(buf, modeRGB, modeAlpha);
		}
		
		public static void glBlendFunci(uint buf, uint src, uint dst)
		{
			XWGL.GetDelegateFor<glBlendFunciDelegate>()(buf, src, dst);
		}
		
		public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			XWGL.GetDelegateFor<glBlendFuncSeparateiDelegate>()(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}
		
		public static void glDrawArraysIndirect(uint mode, nint indirect)
		{
			XWGL.GetDelegateFor<glDrawArraysIndirectDelegate>()(mode, indirect);
		}
		
		public static void glDrawElementsIndirect(uint mode, uint type, nint indirect)
		{
			XWGL.GetDelegateFor<glDrawElementsIndirectDelegate>()(mode, type, indirect);
		}
		
		public static void glUniform1d(uint location, double x)
		{
			XWGL.GetDelegateFor<glUniform1dDelegate>()(location, x);
		}
		
		public static void glUniform2d(uint location, double x, double y)
		{
			XWGL.GetDelegateFor<glUniform2dDelegate>()(location, x, y);
		}
		
		public static void glUniform3d(uint location, double x, double y, double z)
		{
			XWGL.GetDelegateFor<glUniform3dDelegate>()(location, x, y, z);
		}
		
		public static void glUniform4d(uint location, double x, double y, double z, double w)
		{
			XWGL.GetDelegateFor<glUniform4dDelegate>()(location, x, y, z, w);
		}
		
		public static void glUniform1dv(uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glUniform1dvDelegate>()(location, count, value);
		}
		
		public static void glUniform2dv(uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glUniform2dvDelegate>()(location, count, value);
		}
		
		public static void glUniform3dv(uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glUniform3dvDelegate>()(location, count, value);
		}
		
		public static void glUniform4dv(uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glUniform4dvDelegate>()(location, count, value);
		}
		
		public static void glUniformMatrix2dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x3dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix2x4dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix2x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x2dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix3x4dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix3x4dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x2dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x2dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glUniformMatrix4x3dv(uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glUniformMatrix4x3dvDelegate>()(location, count, transpose, value);
		}
		
		public static void glGetUniformdv(uint program, uint location, double[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformdvDelegate>()(program, location, @params);
		}
		
		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, char[] name)
		{
			return (int)XWGL.GetDelegateFor<glGetSubroutineUniformLocationDelegate>()(program, shadertype, name);
		}
		
		public static uint glGetSubroutineIndex(uint program, uint shadertype, char[] name)
		{
			return (uint)XWGL.GetDelegateFor<glGetSubroutineIndexDelegate>()(program, shadertype, name);
		}
		
		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values)
		{
			XWGL.GetDelegateFor<glGetActiveSubroutineUniformivDelegate>()(program, shadertype, index, pname, values);
		}
		
		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			XWGL.GetDelegateFor<glGetActiveSubroutineUniformNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, char[] name)
		{
			XWGL.GetDelegateFor<glGetActiveSubroutineNameDelegate>()(program, shadertype, index, bufsize, length, name);
		}
		
		public static void glUniformSubroutinesuiv(uint shadertype, int count, uint[] indices)
		{
			XWGL.GetDelegateFor<glUniformSubroutinesuivDelegate>()(shadertype, count, indices);
		}
		
		public static void glGetUniformSubroutineuiv(uint shadertype, uint location, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetUniformSubroutineuivDelegate>()(shadertype, location, @params);
		}
		
		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int[] values)
		{
			XWGL.GetDelegateFor<glGetProgramStageivDelegate>()(program, shadertype, pname, values);
		}
		
		public static void glPatchParameteri(uint pname, int value)
		{
			XWGL.GetDelegateFor<glPatchParameteriDelegate>()(pname, value);
		}
		
		public static void glPatchParameterfv(uint pname, float[] values)
		{
			XWGL.GetDelegateFor<glPatchParameterfvDelegate>()(pname, values);
		}
		
		public static void glBindTransformFeedback(uint target, uint id)
		{
			XWGL.GetDelegateFor<glBindTransformFeedbackDelegate>()(target, id);
		}
		
		public static void glDeleteTransformFeedbacks(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glDeleteTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glGenTransformFeedbacks(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glGenTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static bool glIsTransformFeedback(uint id)
		{
			return (bool)XWGL.GetDelegateFor<glIsTransformFeedbackDelegate>()(id);
		}
		
		public static void glPauseTransformFeedback()
		{
			XWGL.GetDelegateFor<glPauseTransformFeedbackDelegate>()();
		}
		
		public static void glResumeTransformFeedback()
		{
			XWGL.GetDelegateFor<glResumeTransformFeedbackDelegate>()();
		}
		
		public static void glDrawTransformFeedback(uint mode, uint id)
		{
			XWGL.GetDelegateFor<glDrawTransformFeedbackDelegate>()(mode, id);
		}
		
		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			XWGL.GetDelegateFor<glDrawTransformFeedbackStreamDelegate>()(mode, id, stream);
		}
		
		public static void glBeginQueryIndexed(uint target, uint index, uint id)
		{
			XWGL.GetDelegateFor<glBeginQueryIndexedDelegate>()(target, index, id);
		}
		
		public static void glEndQueryIndexed(uint target, uint index)
		{
			XWGL.GetDelegateFor<glEndQueryIndexedDelegate>()(target, index);
		}
		
		public static void glGetQueryIndexediv(uint target, uint index, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetQueryIndexedivDelegate>()(target, index, pname, @params);
		}

        public static void glReleaseShaderCompiler()
		{
			XWGL.GetDelegateFor<glReleaseShaderCompilerDelegate>()();
		}
		
		public static void glShaderBinary(int count, uint[] shaders, uint binaryformat, nint binary, int length)
		{
			XWGL.GetDelegateFor<glShaderBinaryDelegate>()(count, shaders, binaryformat, binary, length);
		}
		
		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
		{
			XWGL.GetDelegateFor<glGetShaderPrecisionFormatDelegate>()(shadertype, precisiontype, range, precision);
		}
		
		public static void glDepthRangef(float n, float f)
		{
			XWGL.GetDelegateFor<glDepthRangefDelegate>()(n, f);
		}
		
		public static void glClearDepthf(float d)
		{
			XWGL.GetDelegateFor<glClearDepthfDelegate>()(d);
		}
		
		public static void glGetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, nint binary)
		{
			XWGL.GetDelegateFor<glGetProgramBinaryDelegate>()(program, bufSize, length, binaryFormat, binary);
		}
		
		public static void glProgramBinary(uint program, uint binaryFormat, nint binary, int length)
		{
			XWGL.GetDelegateFor<glProgramBinaryDelegate>()(program, binaryFormat, binary, length);
		}
		
		public static void glProgramParameteri(uint program, uint pname, int value)
		{
			XWGL.GetDelegateFor<glProgramParameteriDelegate>()(program, pname, value);
		}
		
		public static void glUseProgramStages(uint pipeline, uint stages, uint program)
		{
			XWGL.GetDelegateFor<glUseProgramStagesDelegate>()(pipeline, stages, program);
		}
		
		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			XWGL.GetDelegateFor<glActiveShaderProgramDelegate>()(pipeline, program);
		}
		
		public static uint glCreateShaderProgramv(uint type, int count, char[] strings)
		{
			return (uint)XWGL.GetDelegateFor<glCreateShaderProgramvDelegate>()(type, count, strings);
		}
		
		public static void glBindProgramPipeline(uint pipeline)
		{
			XWGL.GetDelegateFor<glBindProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glDeleteProgramPipelines(int n, uint[] pipelines)
		{
			XWGL.GetDelegateFor<glDeleteProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glGenProgramPipelines(int n, uint[] pipelines)
		{
			XWGL.GetDelegateFor<glGenProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static bool glIsProgramPipeline(uint pipeline)
		{
			return (bool)XWGL.GetDelegateFor<glIsProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetProgramPipelineivDelegate>()(pipeline, pname, @params);
		}
		
		public static void glProgramUniform1i(uint program, uint location, int v0)
		{
			XWGL.GetDelegateFor<glProgramUniform1iDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1iv(uint program, uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform1ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1f(uint program, uint location, float v0)
		{
			XWGL.GetDelegateFor<glProgramUniform1fDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1fv(uint program, uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform1fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1d(uint program, uint location, double v0)
		{
			XWGL.GetDelegateFor<glProgramUniform1dDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1dv(uint program, uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform1dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform1ui(uint program, uint location, uint v0)
		{
			XWGL.GetDelegateFor<glProgramUniform1uiDelegate>()(program, location, v0);
		}
		
		public static void glProgramUniform1uiv(uint program, uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform1uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2i(uint program, uint location, int v0, int v1)
		{
			XWGL.GetDelegateFor<glProgramUniform2iDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2iv(uint program, uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform2ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2f(uint program, uint location, float v0, float v1)
		{
			XWGL.GetDelegateFor<glProgramUniform2fDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2fv(uint program, uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform2fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2d(uint program, uint location, double v0, double v1)
		{
			XWGL.GetDelegateFor<glProgramUniform2dDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2dv(uint program, uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform2dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform2ui(uint program, uint location, uint v0, uint v1)
		{
			XWGL.GetDelegateFor<glProgramUniform2uiDelegate>()(program, location, v0, v1);
		}
		
		public static void glProgramUniform2uiv(uint program, uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform2uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3i(uint program, uint location, int v0, int v1, int v2)
		{
			XWGL.GetDelegateFor<glProgramUniform3iDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3iv(uint program, uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform3ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3f(uint program, uint location, float v0, float v1, float v2)
		{
			XWGL.GetDelegateFor<glProgramUniform3fDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3fv(uint program, uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform3fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3d(uint program, uint location, double v0, double v1, double v2)
		{
			XWGL.GetDelegateFor<glProgramUniform3dDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3dv(uint program, uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform3dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform3ui(uint program, uint location, uint v0, uint v1, uint v2)
		{
			XWGL.GetDelegateFor<glProgramUniform3uiDelegate>()(program, location, v0, v1, v2);
		}
		
		public static void glProgramUniform3uiv(uint program, uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform3uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4i(uint program, uint location, int v0, int v1, int v2, int v3)
		{
			XWGL.GetDelegateFor<glProgramUniform4iDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4iv(uint program, uint location, int count, int[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform4ivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4f(uint program, uint location, float v0, float v1, float v2, float v3)
		{
			XWGL.GetDelegateFor<glProgramUniform4fDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4fv(uint program, uint location, int count, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform4fvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4d(uint program, uint location, double v0, double v1, double v2, double v3)
		{
			XWGL.GetDelegateFor<glProgramUniform4dDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4dv(uint program, uint location, int count, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform4dvDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniform4ui(uint program, uint location, uint v0, uint v1, uint v2, uint v3)
		{
			XWGL.GetDelegateFor<glProgramUniform4uiDelegate>()(program, location, v0, v1, v2, v3);
		}
		
		public static void glProgramUniform4uiv(uint program, uint location, int count, uint[] value)
		{
			XWGL.GetDelegateFor<glProgramUniform4uivDelegate>()(program, location, count, value);
		}
		
		public static void glProgramUniformMatrix2fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4x2fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3x4fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3fv(uint program, uint location, int count, bool transpose, float[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4x3fvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x3dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x2dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix2x4dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix2x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x2dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4x2dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix3x4dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix3x4dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glProgramUniformMatrix4x3dv(uint program, uint location, int count, bool transpose, double[] value)
		{
			XWGL.GetDelegateFor<glProgramUniformMatrix4x3dvDelegate>()(program, location, count, transpose, value);
		}
		
		public static void glValidateProgramPipeline(uint pipeline)
		{
			XWGL.GetDelegateFor<glValidateProgramPipelineDelegate>()(pipeline);
		}
		
		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, char[] infoLog)
		{
			XWGL.GetDelegateFor<glGetProgramPipelineInfoLogDelegate>()(pipeline, bufSize, length, infoLog);
		}
		
		public static void glVertexAttribL1d(uint index, double x)
		{
			XWGL.GetDelegateFor<glVertexAttribL1dDelegate>()(index, x);
		}
		
		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			XWGL.GetDelegateFor<glVertexAttribL2dDelegate>()(index, x, y);
		}
		
		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			XWGL.GetDelegateFor<glVertexAttribL3dDelegate>()(index, x, y, z);
		}
		
		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			XWGL.GetDelegateFor<glVertexAttribL4dDelegate>()(index, x, y, z, w);
		}
		
		public static void glVertexAttribL1dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribL1dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL2dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribL2dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL3dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribL3dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribL4dv(uint index, double[] v)
		{
			XWGL.GetDelegateFor<glVertexAttribL4dvDelegate>()(index, v);
		}
		
		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, nint pointer)
		{
			XWGL.GetDelegateFor<glVertexAttribLPointerDelegate>()(index, size, type, stride, pointer);
		}
		
		public static void glGetVertexAttribLdv(uint index, uint pname, double[] @params)
		{
			XWGL.GetDelegateFor<glGetVertexAttribLdvDelegate>()(index, pname, @params);
		}
		
		public static void glViewportArrayv(uint first, int count, float[] v)
		{
			XWGL.GetDelegateFor<glViewportArrayvDelegate>()(first, count, v);
		}
		
		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			XWGL.GetDelegateFor<glViewportIndexedfDelegate>()(index, x, y, w, h);
		}
		
		public static void glViewportIndexedfv(uint index, float[] v)
		{
			XWGL.GetDelegateFor<glViewportIndexedfvDelegate>()(index, v);
		}
		
		public static void glScissorArrayv(uint first, int count, int[] v)
		{
			XWGL.GetDelegateFor<glScissorArrayvDelegate>()(first, count, v);
		}
		
		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			XWGL.GetDelegateFor<glScissorIndexedDelegate>()(index, left, bottom, width, height);
		}
		
		public static void glScissorIndexedv(uint index, int[] v)
		{
			XWGL.GetDelegateFor<glScissorIndexedvDelegate>()(index, v);
		}
		
		public static void glDepthRangeArrayv(uint first, int count, double[] v)
		{
			XWGL.GetDelegateFor<glDepthRangeArrayvDelegate>()(first, count, v);
		}
		
		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			XWGL.GetDelegateFor<glDepthRangeIndexedDelegate>()(index, n, f);
		}
		
		public static void glGetFloati_v(uint target, uint index, float[] data)
		{
			XWGL.GetDelegateFor<glGetFloati_vDelegate>()(target, index, data);
		}
		
		public static void glGetDoublei_v(uint target, uint index, double[] data)
		{
			XWGL.GetDelegateFor<glGetDoublei_vDelegate>()(target, index, data);
		}

        public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			XWGL.GetDelegateFor<glDrawArraysInstancedBaseInstanceDelegate>()(mode, first, count, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, nint indices, int instancecount, uint baseinstance)
		{
			XWGL.GetDelegateFor<glDrawElementsInstancedBaseInstanceDelegate>()(mode, count, type, indices, instancecount, baseinstance);
		}
		
		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, nint indices, int instancecount, int basevertex, uint baseinstance)
		{
			XWGL.GetDelegateFor<glDrawElementsInstancedBaseVertexBaseInstanceDelegate>()(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}
		
		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params)
		{
			XWGL.GetDelegateFor<glGetInternalformativDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetActiveAtomicCounterBufferivDelegate>()(program, bufferIndex, pname, @params);
		}
		
		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			XWGL.GetDelegateFor<glBindImageTextureDelegate>()(unit, texture, level, layered, layer, access, format);
		}
		
		public static void glMemoryBarrier(uint barriers)
		{
			XWGL.GetDelegateFor<glMemoryBarrierDelegate>()(barriers);
		}
		
		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			XWGL.GetDelegateFor<glTexStorage1DDelegate>()(target, levels, internalformat, width);
		}
		
		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glTexStorage2DDelegate>()(target, levels, internalformat, width, height);
		}
		
		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			XWGL.GetDelegateFor<glTexStorage3DDelegate>()(target, levels, internalformat, width, height, depth);
		}
		
		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawTransformFeedbackInstancedDelegate>()(mode, id, instancecount);
		}
		
		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			XWGL.GetDelegateFor<glDrawTransformFeedbackStreamInstancedDelegate>()(mode, id, stream, instancecount);
		}

        public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearBufferDataDelegate>()(target, internalformat, format, type, data);
		}
		
		public static void glClearBufferSubData(uint target, uint internalformat, nint offset, nint size, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearBufferSubDataDelegate>()(target, internalformat, offset, size, format, type, data);
		}
		
		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			XWGL.GetDelegateFor<glDispatchComputeDelegate>()(num_groups_x, num_groups_y, num_groups_z);
		}
		
		public static void glDispatchComputeIndirect(nint indirect)
		{
			XWGL.GetDelegateFor<glDispatchComputeIndirectDelegate>()(indirect);
		}
		
		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			XWGL.GetDelegateFor<glCopyImageSubDataDelegate>()(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}
		
		public static void glFramebufferParameteri(uint target, uint pname, int param)
		{
			XWGL.GetDelegateFor<glFramebufferParameteriDelegate>()(target, pname, param);
		}
		
		public static void glGetFramebufferParameteriv(uint target, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetFramebufferParameterivDelegate>()(target, pname, @params);
		}
		
		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, Int64[] @params)
		{
			XWGL.GetDelegateFor<glGetInternalformati64vDelegate>()(target, internalformat, pname, bufSize, @params);
		}
		
		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			XWGL.GetDelegateFor<glInvalidateTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}
		
		public static void glInvalidateTexImage(uint texture, int level)
		{
			XWGL.GetDelegateFor<glInvalidateTexImageDelegate>()(texture, level);
		}
		
		public static void glInvalidateBufferSubData(uint buffer, nint offset, nint length)
		{
			XWGL.GetDelegateFor<glInvalidateBufferSubDataDelegate>()(buffer, offset, length);
		}
		
		public static void glInvalidateBufferData(uint buffer)
		{
			XWGL.GetDelegateFor<glInvalidateBufferDataDelegate>()(buffer);
		}
		
		public static void glInvalidateFramebuffer(uint target, int numAttachments, uint[] attachments)
		{
			XWGL.GetDelegateFor<glInvalidateFramebufferDelegate>()(target, numAttachments, attachments);
		}
		
		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glInvalidateSubFramebufferDelegate>()(target, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glMultiDrawArraysIndirect(uint mode, nint indirect, int drawcount, int stride)
		{
			XWGL.GetDelegateFor<glMultiDrawArraysIndirectDelegate>()(mode, indirect, drawcount, stride);
		}
		
		public static void glMultiDrawElementsIndirect(uint mode, uint type, nint indirect, int drawcount, int stride)
		{
			XWGL.GetDelegateFor<glMultiDrawElementsIndirectDelegate>()(mode, type, indirect, drawcount, stride);
		}
		
		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetProgramInterfaceivDelegate>()(program, programInterface, pname, @params);
		}
		
		public static uint glGetProgramResourceIndex(uint program, uint programInterface, char[] name)
		{
			return (uint)XWGL.GetDelegateFor<glGetProgramResourceIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, char[] name)
		{
			XWGL.GetDelegateFor<glGetProgramResourceNameDelegate>()(program, programInterface, index, bufSize, length, name);
		}
		
		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params)
		{
			XWGL.GetDelegateFor<glGetProgramResourceivDelegate>()(program, programInterface, index, propCount, props, bufSize, length, @params);
		}
		
		public static int glGetProgramResourceLocation(uint program, uint programInterface, char[] name)
		{
			return (int)XWGL.GetDelegateFor<glGetProgramResourceLocationDelegate>()(program, programInterface, name);
		}
		
		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, char[] name)
		{
			return (int)XWGL.GetDelegateFor<glGetProgramResourceLocationIndexDelegate>()(program, programInterface, name);
		}
		
		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			XWGL.GetDelegateFor<glShaderStorageBlockBindingDelegate>()(program, storageBlockIndex, storageBlockBinding);
		}
		
		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, nint offset, nint size)
		{
			XWGL.GetDelegateFor<glTexBufferRangeDelegate>()(target, internalformat, buffer, offset, size);
		}
		
		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTexStorage2DMultisampleDelegate>()(target, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTexStorage3DMultisampleDelegate>()(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			XWGL.GetDelegateFor<glTextureViewDelegate>()(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}
		
		public static void glBindVertexBuffer(uint bindingindex, uint buffer, nint offset, int stride)
		{
			XWGL.GetDelegateFor<glBindVertexBufferDelegate>()(bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexAttribFormatDelegate>()(attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexAttribIFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexAttribLFormatDelegate>()(attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			XWGL.GetDelegateFor<glVertexAttribBindingDelegate>()(attribindex, bindingindex);
		}
		
		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			XWGL.GetDelegateFor<glVertexBindingDivisorDelegate>()(bindingindex, divisor);
		}
		
		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			XWGL.GetDelegateFor<glDebugMessageControlDelegate>()(source, type, severity, count, ids, enabled);
		}
		
		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, char[] buf)
		{
			XWGL.GetDelegateFor<glDebugMessageInsertDelegate>()(source, type, id, severity, length, buf);
		}
		
		public static void glDebugMessageCallback(nint callback, nint userParam)
		{
			XWGL.GetDelegateFor<glDebugMessageCallbackDelegate>()(callback, userParam);
		}
		
		public static uint glGetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, char[] messageLog)
		{
			return (uint)XWGL.GetDelegateFor<glGetDebugMessageLogDelegate>()(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}
		
		public static void glPushDebugGroup(uint source, uint id, int length, char[] message)
		{
			XWGL.GetDelegateFor<glPushDebugGroupDelegate>()(source, id, length, message);
		}
		
		public static void glPopDebugGroup()
		{
			XWGL.GetDelegateFor<glPopDebugGroupDelegate>()();
		}
		
		public static void glObjectLabel(uint identifier, uint name, int length, char[] label)
		{
			XWGL.GetDelegateFor<glObjectLabelDelegate>()(identifier, name, length, label);
		}
		
		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int[] length, char[] label)
		{
			XWGL.GetDelegateFor<glGetObjectLabelDelegate>()(identifier, name, bufSize, length, label);
		}
		
		public static void glObjectPtrLabel(nint ptr, int length, char[] label)
		{
			XWGL.GetDelegateFor<glObjectPtrLabelDelegate>()(ptr, length, label);
		}
		
		public static void glGetObjectPtrLabel(nint ptr, int bufSize, int[] length, char[] label)
		{
			XWGL.GetDelegateFor<glGetObjectPtrLabelDelegate>()(ptr, bufSize, length, label);
		}
		
		public static void glBufferStorage(uint target, nint size, nint data, uint flags)
		{
			XWGL.GetDelegateFor<glBufferStorageDelegate>()(target, size, data, flags);
		}
		
		public static void glClearTexImage(uint texture, int level, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearTexImageDelegate>()(texture, level, format, type, data);
		}
		
		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearTexSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}
		
		public static void glBindBuffersBase(uint target, uint first, int count, uint[] buffers)
		{
			XWGL.GetDelegateFor<glBindBuffersBaseDelegate>()(target, first, count, buffers);
		}
		
		public static void glBindBuffersRange(uint target, uint first, int count, uint[] buffers, nint offsets, nint sizes)
		{
			XWGL.GetDelegateFor<glBindBuffersRangeDelegate>()(target, first, count, buffers, offsets, sizes);
		}
		
		public static void glBindTextures(uint first, int count, uint[] textures)
		{
			XWGL.GetDelegateFor<glBindTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindSamplers(uint first, int count, uint[] samplers)
		{
			XWGL.GetDelegateFor<glBindSamplersDelegate>()(first, count, samplers);
		}
		
		public static void glBindImageTextures(uint first, int count, uint[] textures)
		{
			XWGL.GetDelegateFor<glBindImageTexturesDelegate>()(first, count, textures);
		}
		
		public static void glBindVertexBuffers(uint first, int count, uint[] buffers, nint offsets, int[] strides)
		{
			XWGL.GetDelegateFor<glBindVertexBuffersDelegate>()(first, count, buffers, offsets, strides);
		}

        public static void glClipControl(uint origin, uint depth)
		{
			XWGL.GetDelegateFor<glClipControlDelegate>()(origin, depth);
		}
		
		public static void glCreateTransformFeedbacks(int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glCreateTransformFeedbacksDelegate>()(n, ids);
		}
		
		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			XWGL.GetDelegateFor<glTransformFeedbackBufferBaseDelegate>()(xfb, index, buffer);
		}
		
		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, nint offset, nint size)
		{
			XWGL.GetDelegateFor<glTransformFeedbackBufferRangeDelegate>()(xfb, index, buffer, offset, size);
		}
		
		public static void glGetTransformFeedbackiv(uint xfb, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbackivDelegate>()(xfb, pname, param);
		}
		
		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbacki_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, Int64[] param)
		{
			XWGL.GetDelegateFor<glGetTransformFeedbacki64_vDelegate>()(xfb, pname, index, param);
		}
		
		public static void glCreateBuffers(int n, uint[] buffers)
		{
			XWGL.GetDelegateFor<glCreateBuffersDelegate>()(n, buffers);
		}
		
		public static void glNamedBufferStorage(uint buffer, nint size, nint data, uint flags)
		{
			XWGL.GetDelegateFor<glNamedBufferStorageDelegate>()(buffer, size, data, flags);
		}
		
		public static void glNamedBufferData(uint buffer, nint size, nint data, uint usage)
		{
			XWGL.GetDelegateFor<glNamedBufferDataDelegate>()(buffer, size, data, usage);
		}
		
		public static void glNamedBufferSubData(uint buffer, nint offset, nint size, nint data)
		{
			XWGL.GetDelegateFor<glNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size)
		{
			XWGL.GetDelegateFor<glCopyNamedBufferSubDataDelegate>()(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}
		
		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearNamedBufferDataDelegate>()(buffer, internalformat, format, type, data);
		}
		
		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, nint data)
		{
			XWGL.GetDelegateFor<glClearNamedBufferSubDataDelegate>()(buffer, internalformat, offset, size, format, type, data);
		}
		
		public static void glMapNamedBuffer(uint buffer, uint access)
		{
			XWGL.GetDelegateFor<glMapNamedBufferDelegate>()(buffer, access);
		}
		
		public static void glMapNamedBufferRange(uint buffer, nint offset, nint length, uint access)
		{
			XWGL.GetDelegateFor<glMapNamedBufferRangeDelegate>()(buffer, offset, length, access);
		}
		
		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return (bool)XWGL.GetDelegateFor<glUnmapNamedBufferDelegate>()(buffer);
		}
		
		public static void glFlushMappedNamedBufferRange(uint buffer, nint offset, nint length)
		{
			XWGL.GetDelegateFor<glFlushMappedNamedBufferRangeDelegate>()(buffer, offset, length);
		}
		
		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferParameterivDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, Int64[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferParameteri64vDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferPointerv(uint buffer, uint pname, nint @params)
		{
			XWGL.GetDelegateFor<glGetNamedBufferPointervDelegate>()(buffer, pname, @params);
		}
		
		public static void glGetNamedBufferSubData(uint buffer, nint offset, nint size, nint data)
		{
			XWGL.GetDelegateFor<glGetNamedBufferSubDataDelegate>()(buffer, offset, size, data);
		}
		
		public static void glCreateFramebuffers(int n, uint[] framebuffers)
		{
			XWGL.GetDelegateFor<glCreateFramebuffersDelegate>()(n, framebuffers);
		}
		
		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			XWGL.GetDelegateFor<glNamedFramebufferRenderbufferDelegate>()(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}
		
		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			XWGL.GetDelegateFor<glNamedFramebufferParameteriDelegate>()(framebuffer, pname, param);
		}
		
		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			XWGL.GetDelegateFor<glNamedFramebufferTextureDelegate>()(framebuffer, attachment, texture, level);
		}
		
		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			XWGL.GetDelegateFor<glNamedFramebufferTextureLayerDelegate>()(framebuffer, attachment, texture, level, layer);
		}
		
		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			XWGL.GetDelegateFor<glNamedFramebufferDrawBufferDelegate>()(framebuffer, buf);
		}
		
		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs)
		{
			XWGL.GetDelegateFor<glNamedFramebufferDrawBuffersDelegate>()(framebuffer, n, bufs);
		}
		
		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			XWGL.GetDelegateFor<glNamedFramebufferReadBufferDelegate>()(framebuffer, src);
		}
		
		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments)
		{
			XWGL.GetDelegateFor<glInvalidateNamedFramebufferDataDelegate>()(framebuffer, numAttachments, attachments);
		}
		
		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glInvalidateNamedFramebufferSubDataDelegate>()(framebuffer, numAttachments, attachments, x, y, width, height);
		}
		
		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferuivDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferfvDelegate>()(framebuffer, buffer, drawbuffer, value);
		}
		
		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			XWGL.GetDelegateFor<glClearNamedFramebufferfiDelegate>()(framebuffer, buffer, drawbuffer, depth, stencil);
		}
		
		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			XWGL.GetDelegateFor<glBlitNamedFramebufferDelegate>()(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}
		
		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			return (uint)XWGL.GetDelegateFor<glCheckNamedFramebufferStatusDelegate>()(framebuffer, target);
		}
		
		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetNamedFramebufferParameterivDelegate>()(framebuffer, pname, param);
		}
		
		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedFramebufferAttachmentParameterivDelegate>()(framebuffer, attachment, pname, @params);
		}
		
		public static void glCreateRenderbuffers(int n, uint[] renderbuffers)
		{
			XWGL.GetDelegateFor<glCreateRenderbuffersDelegate>()(n, renderbuffers);
		}
		
		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glNamedRenderbufferStorageDelegate>()(renderbuffer, internalformat, width, height);
		}
		
		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glNamedRenderbufferStorageMultisampleDelegate>()(renderbuffer, samples, internalformat, width, height);
		}
		
		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetNamedRenderbufferParameterivDelegate>()(renderbuffer, pname, @params);
		}
		
		public static void glCreateTextures(uint target, int n, uint[] textures)
		{
			XWGL.GetDelegateFor<glCreateTexturesDelegate>()(target, n, textures);
		}
		
		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			XWGL.GetDelegateFor<glTextureBufferDelegate>()(texture, internalformat, buffer);
		}
		
		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, nint offset, nint size)
		{
			XWGL.GetDelegateFor<glTextureBufferRangeDelegate>()(texture, internalformat, buffer, offset, size);
		}
		
		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			XWGL.GetDelegateFor<glTextureStorage1DDelegate>()(texture, levels, internalformat, width);
		}
		
		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			XWGL.GetDelegateFor<glTextureStorage2DDelegate>()(texture, levels, internalformat, width, height);
		}
		
		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			XWGL.GetDelegateFor<glTextureStorage3DDelegate>()(texture, levels, internalformat, width, height, depth);
		}
		
		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTextureStorage2DMultisampleDelegate>()(texture, samples, internalformat, width, height, fixedsamplelocations);
		}
		
		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			XWGL.GetDelegateFor<glTextureStorage3DMultisampleDelegate>()(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}
		
		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, nint pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, type, pixels);
		}
		
		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, nint pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, nint pixels)
		{
			XWGL.GetDelegateFor<glTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		
		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage1DDelegate>()(texture, level, xoffset, width, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		
		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, nint data)
		{
			XWGL.GetDelegateFor<glCompressedTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		
		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage1DDelegate>()(texture, level, xoffset, x, y, width);
		}
		
		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage2DDelegate>()(texture, level, xoffset, yoffset, x, y, width, height);
		}
		
		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			XWGL.GetDelegateFor<glCopyTextureSubImage3DDelegate>()(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		
		public static void glTextureParameterf(uint texture, uint pname, float param)
		{
			XWGL.GetDelegateFor<glTextureParameterfDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterfv(uint texture, uint pname, float[] param)
		{
			XWGL.GetDelegateFor<glTextureParameterfvDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameteri(uint texture, uint pname, int param)
		{
			XWGL.GetDelegateFor<glTextureParameteriDelegate>()(texture, pname, param);
		}
		
		public static void glTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glTextureParameteriv(uint texture, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glTextureParameterivDelegate>()(texture, pname, param);
		}
		
		public static void glGenerateTextureMipmap(uint texture)
		{
			XWGL.GetDelegateFor<glGenerateTextureMipmapDelegate>()(texture);
		}
		
		public static void glBindTextureUnit(uint unit, uint texture)
		{
			XWGL.GetDelegateFor<glBindTextureUnitDelegate>()(unit, texture);
		}
		
		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetTextureImageDelegate>()(texture, level, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetCompressedTextureImageDelegate>()(texture, level, bufSize, pixels);
		}
		
		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureLevelParameterfvDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureLevelParameterivDelegate>()(texture, level, pname, @params);
		}
		
		public static void glGetTextureParameterfv(uint texture, uint pname, float[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterfvDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterIivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterIuivDelegate>()(texture, pname, @params);
		}
		
		public static void glGetTextureParameteriv(uint texture, uint pname, int[] @params)
		{
			XWGL.GetDelegateFor<glGetTextureParameterivDelegate>()(texture, pname, @params);
		}
		
		public static void glCreateVertexArrays(int n, uint[] arrays)
		{
			XWGL.GetDelegateFor<glCreateVertexArraysDelegate>()(n, arrays);
		}
		
		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			XWGL.GetDelegateFor<glDisableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			XWGL.GetDelegateFor<glEnableVertexArrayAttribDelegate>()(vaobj, index);
		}
		
		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			XWGL.GetDelegateFor<glVertexArrayElementBufferDelegate>()(vaobj, buffer);
		}
		
		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride)
		{
			XWGL.GetDelegateFor<glVertexArrayVertexBufferDelegate>()(vaobj, bindingindex, buffer, offset, stride);
		}
		
		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, nint offsets, int[] strides)
		{
			XWGL.GetDelegateFor<glVertexArrayVertexBuffersDelegate>()(vaobj, first, count, buffers, offsets, strides);
		}
		
		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribBindingDelegate>()(vaobj, attribindex, bindingindex);
		}
		
		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribFormatDelegate>()(vaobj, attribindex, size, type, normalized, relativeoffset);
		}
		
		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribIFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			XWGL.GetDelegateFor<glVertexArrayAttribLFormatDelegate>()(vaobj, attribindex, size, type, relativeoffset);
		}
		
		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			XWGL.GetDelegateFor<glVertexArrayBindingDivisorDelegate>()(vaobj, bindingindex, divisor);
		}
		
		public static void glGetVertexArrayiv(uint vaobj, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayivDelegate>()(vaobj, pname, param);
		}
		
		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayIndexedivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, Int64[] param)
		{
			XWGL.GetDelegateFor<glGetVertexArrayIndexed64ivDelegate>()(vaobj, index, pname, param);
		}
		
		public static void glCreateSamplers(int n, uint[] samplers)
		{
			XWGL.GetDelegateFor<glCreateSamplersDelegate>()(n, samplers);
		}
		
		public static void glCreateProgramPipelines(int n, uint[] pipelines)
		{
			XWGL.GetDelegateFor<glCreateProgramPipelinesDelegate>()(n, pipelines);
		}
		
		public static void glCreateQueries(uint target, int n, uint[] ids)
		{
			XWGL.GetDelegateFor<glCreateQueriesDelegate>()(target, n, ids);
		}
		
		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, nint offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjecti64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, nint offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, nint offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectui64vDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, nint offset)
		{
			XWGL.GetDelegateFor<glGetQueryBufferObjectuivDelegate>()(id, buffer, pname, offset);
		}
		
		public static void glMemoryBarrierByRegion(uint barriers)
		{
			XWGL.GetDelegateFor<glMemoryBarrierByRegionDelegate>()(barriers);
		}
		
		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}
		
		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetCompressedTextureSubImageDelegate>()(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}
		
		public static uint glGetGraphicsResetStatus()
		{
			return (uint)XWGL.GetDelegateFor<glGetGraphicsResetStatusDelegate>()();
		}
		
		public static void glGetnCompressedTexImage(uint target, int lod, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetnCompressedTexImageDelegate>()(target, lod, bufSize, pixels);
		}
		
		public static void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, nint pixels)
		{
			XWGL.GetDelegateFor<glGetnTexImageDelegate>()(target, level, format, type, bufSize, pixels);
		}
		
		public static void glGetnUniformdv(uint program, uint location, int bufSize, double[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformdvDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformfv(uint program, uint location, int bufSize, float[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformfvDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformiv(uint program, uint location, int bufSize, int[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformivDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glGetnUniformuiv(uint program, uint location, int bufSize, uint[] @params)
		{
			XWGL.GetDelegateFor<glGetnUniformuivDelegate>()(program, location, bufSize, @params);
		}
		
		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, nint data)
		{
			XWGL.GetDelegateFor<glReadnPixelsDelegate>()(x, y, width, height, format, type, bufSize, data);
		}
		
		public static void glGetnMapdv(uint target, uint query, int bufSize, double[] v)
		{
			XWGL.GetDelegateFor<glGetnMapdvDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapfv(uint target, uint query, int bufSize, float[] v)
		{
			XWGL.GetDelegateFor<glGetnMapfvDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnMapiv(uint target, uint query, int bufSize, int[] v)
		{
			XWGL.GetDelegateFor<glGetnMapivDelegate>()(target, query, bufSize, v);
		}
		
		public static void glGetnPixelMapfv(uint map, int bufSize, float[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapfvDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapuiv(uint map, int bufSize, uint[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapuivDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPixelMapusv(uint map, int bufSize, ushort[] values)
		{
			XWGL.GetDelegateFor<glGetnPixelMapusvDelegate>()(map, bufSize, values);
		}
		
		public static void glGetnPolygonStipple(int bufSize, byte[] pattern)
		{
			XWGL.GetDelegateFor<glGetnPolygonStippleDelegate>()(bufSize, pattern);
		}
		
		public static void glGetnColorTable(uint target, uint format, uint type, int bufSize, nint table)
		{
			XWGL.GetDelegateFor<glGetnColorTableDelegate>()(target, format, type, bufSize, table);
		}
		
		public static void glGetnConvolutionFilter(uint target, uint format, uint type, int bufSize, nint image)
		{
			XWGL.GetDelegateFor<glGetnConvolutionFilterDelegate>()(target, format, type, bufSize, image);
		}
		
		public static void glGetnSeparableFilter(uint target, uint format, uint type, int rowBufSize, nint row, int columnBufSize, nint column, nint span)
		{
			XWGL.GetDelegateFor<glGetnSeparableFilterDelegate>()(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}
		
		public static void glGetnHistogram(uint target, bool reset, uint format, uint type, int bufSize, nint values)
		{
			XWGL.GetDelegateFor<glGetnHistogramDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glGetnMinmax(uint target, bool reset, uint format, uint type, int bufSize, nint values)
		{
			XWGL.GetDelegateFor<glGetnMinmaxDelegate>()(target, reset, format, type, bufSize, values);
		}
		
		public static void glTextureBarrier()
		{
			XWGL.GetDelegateFor<glTextureBarrierDelegate>()();
		}

		#endregion
    }
}