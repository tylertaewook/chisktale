///scr_move_state
right_key = keyboard_check(vk_right);
left_key = keyboard_check(vk_left);
down_key = keyboard_check(vk_down);
up_key = keyboard_check(vk_up);

if (right_key) {
    phy_position_x += 3;
    sprite_index = spr_right;
    image_speed = .1;
}

if (left_key) {
    phy_position_x -= 3;
    sprite_index = spr_left;
    image_speed = .1;
}

if (up_key) {
    phy_position_y -= 3;
    sprite_index = spr_up;
    image_speed = .1;
}

if (down_key) {
    phy_position_y += 3;
    sprite_index = spr_down;
    image_speed = .1;
}
//stop animation
if (!right_key and !left_key and !up_key and !down_key) 
{
image_speed = 0;
image_index = 0;
}
