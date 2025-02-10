from PIL import Image, ImageDraw, ImageFont

def generate_image(desc, cardType, background, name):
    # Load background image
    bg_img = Image.open(background)

    # Load card type image and paste onto background
    card_type_img = Image.open(f"{cardType}.png")  # assuming cardType is the name of the image file
    bg_img.paste(card_type_img, (0, 0), card_type_img)

    # Load name font and draw onto background
    name_font = ImageFont.truetype("arial.ttf", 36)  # assuming arial.ttf is the font file
    draw = ImageDraw.Draw(bg_img)
    draw.text((50, 50), name, font=name_font, fill=(255, 255, 255))

    # Load description font and draw onto background in a box
    desc_font = ImageFont.truetype("times.ttf", 24)  # assuming times.ttf is the font file
    desc_box_width = 500
    desc_box_height = 200
    desc_box_pos = (50, 150)
    draw.rectangle((desc_box_pos, (desc_box_pos[0] + desc_box_width, desc_box_pos[1] + desc_box_height)), fill=(255, 255, 255))
    draw.text((desc_box_pos[0] + 10, desc_box_pos[1] + 10), desc, font=desc_font, fill=(0, 0, 0))

    # Save and return image
    outputfile = f"{name}{cardType}.png"
    bg_img.save(output_file)
    return output_file



